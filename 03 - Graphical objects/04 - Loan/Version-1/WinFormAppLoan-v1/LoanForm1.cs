using ClassLibraryLoan_v1;
using ClassLibraryLoanTool_v1;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace WinFormAppLoan_v1
{
    public partial class LoanForm1 : Form
    {
        #region ############### PROPERTIES ###############
        private Loan CurrentLoan
        {
            get; set;
        }

        private BindingList<RepaymentPeriodicity> CurrentRepaymentPeriodicityBindingList
        {
            get; set;
        }
        #endregion

        #region ############### CONSTRUCTOR ###############
        public LoanForm1()
        {
            InitializeComponent();
            CurrentLoan = new Loan();
            CurrentRepaymentPeriodicityBindingList = new BindingList<RepaymentPeriodicity>(Enum.GetValues(typeof(RepaymentPeriodicity)).OfType<RepaymentPeriodicity>().ToList());
            lbRepaymentPeriodicity.DataSource = CurrentRepaymentPeriodicityBindingList;
            UpdateHMI_All();
        }

        public LoanForm1(int instanceNumber)
        {
            InitializeComponent();
            CurrentLoan = new Loan();
            CurrentRepaymentPeriodicityBindingList = new BindingList<RepaymentPeriodicity>(Enum.GetValues(typeof(RepaymentPeriodicity)).OfType<RepaymentPeriodicity>().ToList());
            lbRepaymentPeriodicity.DataSource = CurrentRepaymentPeriodicityBindingList;
            Text = $"Loan application number : {instanceNumber}";
            UpdateHMI_All();
        }

        #endregion

        #region ############### METHODS ###############
        /// <summary>
        /// This method clears the errorProvider form the TextBox given as an argument
        /// </summary>
        /// <param name="sender">object</param>
        private void ClearErrorProvider(object sender)
        {
            if ((TextBox)sender == tbName)
                errorProviderName.Clear();
            else
                errorProviderCapital.Clear();
        }

        /// <summary>
        /// This methods checks wether the form is correctly filled or not
        /// </summary>
        /// <returns>bool</returns>
        private bool FormIsCorrect()
        {
            if (tbName.Text.Length == 0)
                return false;
            if (tbBorrowedCapital.Text.Length == 0)
                return false;
            if (!StringChecker.IsValidName(tbName.Text))
                return false;
            if (!StringChecker.IsValidAmount(tbBorrowedCapital.Text))
                return false;
            return true;
        }

        /// <summary>
        /// This methods checks if the form is empty
        /// </summary>
        /// <returns></returns>
        private bool FormIsEmpty()
        {
            if (tbName.Text.Length != 0)
                return false;
            if (tbBorrowedCapital.Text.Length != 0)
                return false;
            if (hsbRepaymentDuration.Value != 1)
                return false;
            if (lbRepaymentPeriodicity.SelectedIndex != 0)
                return false;
            if (rbSeven.Checked != true)
                return false;
            return true;
        }

        /// <summary>
        /// This method sets the new minimum value of the hsbRepaymentDuration to the current object periodicity
        /// It also change the incrementation (small change) depending on the periodicity
        /// </summary>
        private void SetChangesOnHSB()
        {
            hsbRepaymentDuration.Minimum = Convert.ToInt32(CurrentLoan.Periodicity);
            hsbRepaymentDuration.SmallChange = Convert.ToInt32(CurrentLoan.Periodicity);
            hsbRepaymentDuration.LargeChange = Convert.ToInt32(CurrentLoan.Periodicity) * 2;
            hsbRepaymentDuration.Maximum = 299 + Convert.ToInt32(CurrentLoan.Periodicity) * 2;
        }

        /// <summary>
        /// This method rounds the current number of months to make it fit perfectly to the new periodicity.
        /// The aim is having (duration % periodicity == 0)
        /// It also updates the hsbRepaymentDuration value
        /// </summary>
        /// <param name="_periodicity">RepaymentPeriodicity</param>
        private void UpdateNumberOfMonths(RepaymentPeriodicity _periodicity)
        {
            int duration = CurrentLoan.DurationInMonths;
            int periodicity = Convert.ToInt32(_periodicity);
            int moduloResult = duration % periodicity;

            if (duration < periodicity)
                CurrentLoan.DurationInMonths = periodicity;
            else if (300 - duration < periodicity)
                CurrentLoan.DurationInMonths = 300;
            else if (moduloResult >= periodicity / 2f)
                CurrentLoan.DurationInMonths += periodicity - moduloResult;
            else
                CurrentLoan.DurationInMonths -= moduloResult;
            hsbRepaymentDuration.Value = CurrentLoan.DurationInMonths;
        }
        #endregion

        #region ############### UPDATE HMI METHODS ###############
        /// <summary>
        /// This method update all the HMI
        /// </summary>
        private void UpdateHMI_All()
        {
            UpdateHMI_labNumberOfMonths();
            UpdateHMI_labResult();
            UpdateHMI_buttons();
        }

        /// <summary>
        /// This method updates buttons depending of the Form state
        /// </summary>
        private void UpdateHMI_buttons()
        {
            if (FormIsEmpty())
            {
                btnSave.Enabled = false;
                btnReset.Enabled = false;
            }
            else if (FormIsCorrect())
            {
                btnSave.Enabled = true;
                btnReset.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                btnReset.Enabled = true;
            }
        }

        /// <summary>
        /// This method updates the label labNumberOfMonths
        /// </summary>
        private void UpdateHMI_labNumberOfMonths()
        {
            if (CurrentLoan.DurationInMonths == 1)
                labNumberOfMonths.Text = $"{CurrentLoan.DurationInMonths} month";
            else
                labNumberOfMonths.Text = $"{CurrentLoan.DurationInMonths} months";
        }

        /// <summary>
        /// This method updates the result and its visibility
        /// </summary>
        private void UpdateHMI_labResult()
        {
            // Updating result
            if (CurrentLoan.IsValidRepaymentPeriodicity(CurrentLoan.DurationInMonths, CurrentLoan.Periodicity))
            {
                if (CurrentLoan.GetRepaymentNumber() == 1)
                    labResult.Text = $"{CurrentLoan.GetRepaymentNumber()} repayment of {Math.Round(CurrentLoan.GetRepaymentValue(), 2)} $";
                else
                    labResult.Text = $"{CurrentLoan.GetRepaymentNumber()} repayments of {Math.Round(CurrentLoan.GetRepaymentValue(), 2)} $";
            }
            else
                labResult.Text = "Invalid repayment periodicity";

            // Updating the visibility
            if (!FormIsCorrect())
                labResult.Visible = false;
            else
                labResult.Visible = true;
        }
        #endregion

        #region ############### EVENTS ###############

        /// <summary>
        /// This method reset the entireForm
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            CurrentLoan.Name = "";
            tbName.Text = "";
            CurrentLoan.BorrowedCapital = 0f;
            tbBorrowedCapital.Text = "";
            lbRepaymentPeriodicity.SelectedIndex = 0;
            hsbRepaymentDuration.Value = 1;
            rbSeven.Checked = true;
            btnSave.Enabled = false;
            UpdateHMI_All();
        }

        /// <summary>
        /// This method updates the duration in months depending on the periodicity selected
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void HsbRepaymentDuration_Scroll(object sender, ScrollEventArgs e)
        {
            if (labResult.Text == "Invalid repayment periodicity")
            {
                int i = 0;
                int j = 0;
                while (CurrentLoan.DurationInMonths % Convert.ToInt32(CurrentLoan.Periodicity) != 0)
                {
                    if ((CurrentLoan.DurationInMonths + i) % Convert.ToInt32(CurrentLoan.Periodicity) == 0
                     || (CurrentLoan.DurationInMonths + j) % Convert.ToInt32(CurrentLoan.Periodicity) == 0)
                    {
                        if ((CurrentLoan.DurationInMonths + i) % Convert.ToInt32(CurrentLoan.Periodicity) == 0)
                            CurrentLoan.DurationInMonths += i;
                        else
                            CurrentLoan.DurationInMonths += j;
                    }
                    else
                    {
                        i++;
                        j--;
                    }
                }
                SetChangesOnHSB();
                UpdateHMI_All();
            }
        }

        /// <summary>
        /// This method updates the HsbRepaymentDurations value and the current Loan duration in months 
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void HsbRepaymentDurations_ValueChanged(object sender, EventArgs e)
        {
            CurrentLoan.DurationInMonths = hsbRepaymentDuration.Value;
            UpdateHMI_All();
        }

        /// <summary>
        /// This method is triggered when the selected index changes
        /// Update Number of months if needed and change the Loan state
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void LbRepaymentPeriodicity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbRepaymentPeriodicity.SelectedIndex;
            UpdateNumberOfMonths(CurrentRepaymentPeriodicityBindingList.ElementAt<RepaymentPeriodicity>(index));
            CurrentLoan.Periodicity = CurrentRepaymentPeriodicityBindingList.ElementAt<RepaymentPeriodicity>(index);
            SetChangesOnHSB();
            UpdateHMI_All();
        }

        /// <summary>
        /// This method is triggered when the interest rate is changed by checking a radiobutton
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            CurrentLoan.InterestRateInPerCent = Convert.ToInt32(gbInterestRate.Controls.OfType<RadioButton>().ToList().Find(rb => rb.Checked == true).Tag);
            UpdateHMI_All();
        }

        /// <summary>
        /// This methos is triggered when the text changes in the TextBox
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            btnReset.Enabled = true;
            ClearErrorProvider(sender);
            if (!StringChecker.IsValidName(tbName.Text) || !StringChecker.IsValidAmount(tbBorrowedCapital.Text))
            {
                labResult.Visible = false;
                if (!StringChecker.IsValidName(tbName.Text))
                    errorProviderName.SetError(tbName, "Invalid name");
                if (!StringChecker.IsValidAmount(tbBorrowedCapital.Text))
                    errorProviderCapital.SetError(tbBorrowedCapital, "Invalid number");
            }
            else if (!FormIsCorrect())
                labResult.Visible = false;
            else
            {
                btnSave.Enabled = true;
                labResult.Visible = true;
                CurrentLoan.Name = tbName.Text;
                CurrentLoan.BorrowedCapital = float.Parse(tbBorrowedCapital.Text);
            }
            UpdateHMI_All();
        }
        #endregion
    }
}