using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            CopyAllToSource();
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
                lbTarget.Items.Add(_country);
                countryTab.Add(_country);
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
                btnRightShiftAll.Enabled = true;
            if (lbTarget.Items.Count == 0)
            {
                btnLeftShift.Enabled = false;
                btnLeftShiftAll.Enabled = false;
                lbTarget.Enabled = false;
                labTarget.Enabled = false;
            }
            else
            {
                btnLeftShift.Enabled = true;
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
            foreach (string country in countryTab)
                cbSource.Items.Add(country);
            lbTarget.Items.Clear();
        }

        /// <summary>
        /// This method moves all countries to target listBox
        /// </summary>
        private void CopyAllToTarget()
        {
            foreach (string country in countryTab)
                lbTarget.Items.Add(country);
            cbSource.Items.Clear();
        }

        private void SwapCountryFromSourceToTarget(string _country)
        {
            if (cbSource.Items.Contains(_country))
            {
                lbTarget.Items.Add(_country);
                cbSource.Items.Remove(_country);
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
            CopyAllToSource();
            CheckIsEmptyBox();
        }

        private void BtnRightShift_Click(object sender, EventArgs e)
        {
            CheckIsEmptyBox();
        }

        private void BtnRightShiftAll_Click(object sender, EventArgs e)
        {
            CopyAllToTarget();
            CheckIsEmptyBox();
        }

        private void CbSource_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (cbSource.Text.Length == 0)
                btnRightShift.Enabled = false;
        }








    }
}
