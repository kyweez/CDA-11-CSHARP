using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxApp
{
    public partial class ComboBoxApp : Form
    {
        /***************************** ATTRIBUTES ****************************/
        private List<string> countryTab;

        /**************************** CONSTRUCTORS ***************************/
        public ComboBoxApp()
        {
            InitializeComponent();
            countryTab = new List<string> { "France", "Belgique", "Allemagne", "Japon", "Portugal", "Grece", "Bulgarie", "Espagne" };
            countryTab.Sort();
            foreach (string country in countryTab)
                cbSource.Items.Add(country);
        }

        /***************************** PROPERTIES ****************************/

        /****************************** METHODS ******************************/

        /// <summary>
        /// This method adds a country to the targetBox and update the countryTab
        /// </summary>
        /// <param name="_country">string</param>
        private void AddCountry(string _country)
        {
            if (_country.Length > 30)
                errorProvider.SetError(cbSource, "Max lenght country name == 30");
            else if (!Regex.IsMatch(_country, @"^[a-zA-Z]+([\-\' ][a-zA-Z]+)*$"))
                errorProvider.SetError(cbSource, "Doesn't respect the classical country name convention");
            else
            {
                lbTarget.Items.Add(FormatCountryName(_country));
                countryTab.Add(FormatCountryName(_country));
                cbSource.Text = "";
            }
        }

        /// <summary>
        /// This method enable or disable buttons depending on box are empty or not
        /// </summary>
        private void CheckIsEmptyBox()
        {
            if (cbSource.Items.Count == 0)
                btnRightShiftAll.Enabled = false;
            else
            {
                if (cbSource.Text.Length == 0)
                    btnRightShift.Enabled = false;
                else
                    btnRightShift.Enabled = true;
            }

            if (lbTarget.Items.Count == 0)
            {
                btnLeftShift.Enabled = false;
                btnLeftShiftAll.Enabled = false;
                lbTarget.Enabled = false;
                labTarget.Enabled = false;
            }
            else
            {
                btnLeftShiftAll.Enabled = true;
                lbTarget.Enabled = true;
                labTarget.Enabled = true;
            }
        }

        /// <summary>
        /// This method moves all countries to source comboBox
        /// </summary>
        private void CopyAllToSource()
        {
            foreach (string country in lbTarget.Items)
                cbSource.Items.Add(country);
            lbTarget.Items.Clear();
        }

        /// <summary>
        /// This method moves all countries to target listBox
        /// </summary>
        private void CopyAllToTarget()
        {
            foreach (string country in cbSource.Items)
                lbTarget.Items.Add(country);
            cbSource.Items.Clear();
        }

        private string FormatCountryName(string _country)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(_country);
        }

        private void SwapCountryFromSourceToTarget(string _country)
        {
            if (cbSource.Items.Contains(_country))
            {
                lbTarget.Items.Add(_country);
                cbSource.Items.Remove(_country);
                cbSource.Text = "";
            }
            else
            {
                if (lbTarget.Items.Contains(_country))
                    errorProvider.SetError(cbSource, "This country already exists");
                else
                    AddCountry(_country);
            }
        }

        /******************************* EVENTS ******************************/

        private void BtnLeftShift_Click(object sender, EventArgs e)
        {
            CheckIsEmptyBox();
        }

        private void BtnLeftShiftAll_Click(object sender, EventArgs e)
        {
            lbTarget.SelectedIndex = -1;
            CopyAllToSource();
            CheckIsEmptyBox();
        }

        private void BtnRightShift_Click(object sender, EventArgs e)
        {
            lbTarget.SelectedIndex = -1;
            SwapCountryFromSourceToTarget(cbSource.Text);
            CheckIsEmptyBox();
        }

        private void BtnRightShiftAll_Click(object sender, EventArgs e)
        {
            cbSource.Text = "";
            lbTarget.SelectedIndex = -1;
            CopyAllToTarget();
            CheckIsEmptyBox();
        }

        private void CbSource_Click(object sender, EventArgs e)
        {
            lbTarget.SelectedIndex = -1;
        }

        private void CbSource_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (cbSource.Text.Length == 0)
                btnRightShift.Enabled = false;
            else
                btnRightShift.Enabled = true;
        }

        private void LbTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTarget.SelectedIndex == -1)
            {
                btnMoveDown.Enabled = false;
                btnMoveUp.Enabled = false;
            }
            else if (lbTarget.SelectedIndex == 0)
            {
                btnMoveDown.Enabled = true;
                btnMoveUp.Enabled = false;
            }
            else if (lbTarget.SelectedIndex == (lbTarget.Items.Count - 1))
            {
                btnMoveDown.Enabled = false;
                btnMoveUp.Enabled = true;
            }
            else
            {
                btnMoveDown.Enabled = true;
                btnMoveUp.Enabled = true;
            }
        }
    }
}
