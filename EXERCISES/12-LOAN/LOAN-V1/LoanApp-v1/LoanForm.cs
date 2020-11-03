using LoanClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
        }
        #endregion
















    }
}
