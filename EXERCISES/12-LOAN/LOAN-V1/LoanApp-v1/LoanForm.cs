using LoanClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilsClassLibrary;

namespace LoanApp_v1
{
    public partial class LoanForm : Form
    {
        private Loan CurrentLoan
        {
            get; set;
        }

        private BindingList<RepaymentPeriodicity> CurrentRepaymentPeriodicity
        {
            get; set;
        }


        public LoanForm()
        {
            InitializeComponent();
            CurrentLoan = new Loan();
            // Gets values of the enum, store in a Array, translate in a typed array, translate in a list and store this in a binding list.

            CurrentRepaymentPeriodicity = new BindingList<RepaymentPeriodicity>(Enum.GetValues(typeof(RepaymentPeriodicity)).OfType<RepaymentPeriodicity>().ToList());
            lbRepaymentPeriodicity.DataSource = CurrentRepaymentPeriodicity;
            UpdateHMI_All();
            btnSave.Enabled = false;
        }

        #region ********** METHODS **********

        private void ClearErrorProvider(object sender)
        {
            if ((TextBox)sender == tbName)
                errorProviderName.Clear();
            else
                errorProviderCapital.Clear();
        }

        private void DisableElements()
        {
            btnSave.Enabled = false;
            labResult.Visible = false;
        }


        private bool FormIsCorrect()
        {
            if (tbName.Text.Length == 0)
                return false;
            if (tbBorrowedCapital.Text.Length == 0)
                return false;
            if (labResult.Text == "Invalid repayment periodicity")
                return false;
            if (!StringChecker.IsValidName(tbName.Text))
                return false;
            if (!StringChecker.IsValidAmount(tbBorrowedCapital.Text))
                return false;
            return true;
        }

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

        private void SetSmallChangeOnHSB()
        {
            hsbRepaymentDuration.Minimum = Convert.ToInt32(CurrentLoan.Periodicity);
            hsbRepaymentDuration.SmallChange = Convert.ToInt32(CurrentLoan.Periodicity);
        }

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

        #region ********** UPDATE HMI METHODS **********
        private void UpdateHMI_All()
        {
            UpdateHMI_labNumberOfMonths();
            UpdateHMI_labResult();
            UpdateHMI_buttons();
        }

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


        private void UpdateHMI_labNumberOfMonths()
        {
            if (CurrentLoan.DurationInMonths == 1)
                labNumberOfMonths.Text = $"{CurrentLoan.DurationInMonths} month";
            else
                labNumberOfMonths.Text = $"{CurrentLoan.DurationInMonths} months";
        }

        private void UpdateHMI_labResult()
        {
            if (CurrentLoan.IsValidRepaymentPeriodicity(CurrentLoan.DurationInMonths, CurrentLoan.Periodicity))
            {
                if (CurrentLoan.GetRepaymentNumber() == 1)
                    labResult.Text = $"{CurrentLoan.GetRepaymentNumber()} repayment of {Math.Round(CurrentLoan.GetRepaymentValue(), 2)} $";
                else
                    labResult.Text = $"{CurrentLoan.GetRepaymentNumber()} repayments of {Math.Round(CurrentLoan.GetRepaymentValue(), 2)} $";
            }
            else
                labResult.Text = "Invalid repayment periodicity";
            if (CurrentLoan.Name == "" || CurrentLoan.BorrowedCapital == 0)
                labResult.Visible = false;
            else
                labResult.Visible = true;
        }

        #endregion

        #region ********** EVENTS **********

        private void btnReset_Click(object sender, EventArgs e)
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

        private void HsbRepaymentDurations_ValueChanged(object sender, EventArgs e)
        {
            CurrentLoan.DurationInMonths = hsbRepaymentDuration.Value;
            UpdateHMI_All();
        }

        private void LbRepaymentPeriodicity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbRepaymentPeriodicity.SelectedIndex;
            UpdateNumberOfMonths(CurrentRepaymentPeriodicity.ElementAt<RepaymentPeriodicity>(index));
            CurrentLoan.Periodicity = CurrentRepaymentPeriodicity.ElementAt<RepaymentPeriodicity>(index);
            SetSmallChangeOnHSB();
            UpdateHMI_All();
        }

        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            CurrentLoan.InterestRateInPerCent = Convert.ToInt32(gbInterestRate.Controls.OfType<RadioButton>().ToList().Find(rb => rb.Checked == true).Tag);
            UpdateHMI_All();
        }



        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            btnReset.Enabled = true;
            ClearErrorProvider(sender);
            if (!StringChecker.IsValidName(tbName.Text) || !StringChecker.IsValidAmount(tbBorrowedCapital.Text))
            {
                DisableElements();
                if (!StringChecker.IsValidName(tbName.Text))
                    errorProviderName.SetError(tbName, "Invalid name");
                if (!StringChecker.IsValidAmount(tbBorrowedCapital.Text))
                    errorProviderCapital.SetError(tbBorrowedCapital, "Invalid number format");
            }
            else if (tbName.Text.Length == 0 || tbBorrowedCapital.Text.Length == 0)
                DisableElements();
            else
            {
                btnSave.Enabled = true;
                labResult.Visible = true;
                CurrentLoan.Name = tbName.Text;
                CurrentLoan.BorrowedCapital = float.Parse(tbBorrowedCapital.Text);
                UpdateHMI_All();
            }
        }
        #endregion
    }
}