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

        #endregion

        #region ********** UPDATE HMI METHODS **********
        private void UpdateHMI_All()
        {
            UpdateHMI_labNumberOfMonths();
            UpdateHMI_lbRepaymentPeriodicity();
            UpdateHMI_labResult();
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
            if (CurrentLoan.GetRepaymentNumber() == 1)
                labResult.Text = $"{CurrentLoan.GetRepaymentNumber()} month";
            else
                labResult.Text = $"{CurrentLoan.GetRepaymentNumber()} months";

            if (CurrentLoan.Name == "" || CurrentLoan.BorrowedCapital == 0)
                labResult.Visible = false;
            else
                labResult.Visible = true;
        }

        private void UpdateHMI_lbRepaymentPeriodicity()
        {
            CurrentRepaymentPeriodicity.Clear();
            foreach (RepaymentPeriodicity value in Enum.GetValues(typeof(RepaymentPeriodicity)))
            {
                if (CurrentLoan.IsValidRepaymentPeriodicity(CurrentLoan.DurationInMonths, value))
                    CurrentRepaymentPeriodicity.Add(value);
            }
        }
        #endregion

        #region ********** EVENTS **********
        private void HsbRepaymentDurations_ValueChanged(object sender, EventArgs e)
        {
            CurrentLoan.DurationInMonths = hsbRepaymentDuration.Value;
            UpdateHMI_All();
        }

        private void LbRepaymentPeriodicity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int test = lbRepaymentPeriodicity.SelectedIndex;

            if (CurrentRepaymentPeriodicity.Count != 0)
            {
                CurrentLoan.Periodicity = CurrentRepaymentPeriodicity.ElementAt<RepaymentPeriodicity>(test);
                UpdateHMI_All();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
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
