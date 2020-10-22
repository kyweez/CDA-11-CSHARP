using BusinessClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListsApplication
{
    public partial class ListsApplication : Form
    {
        /***************************** ATTRIBUTES ****************************/
        private CountryList countries;

        /**************************** CONSTRUCTORS ***************************/
        public ListsApplication()
        {
            InitializeComponent();
            countries = new CountryList();
            foreach (string country in (new List<string> { "France", "Belgique", "Allemagne", "Japon", "Portugal", "Grece", "Bulgarie", "Espagne" }))
            {
                comboBoxSource.Items.Add(country);
                countries.AddCountry(country);
            }
        }

        /***************************** PROPERTIES ****************************/
        // NONE

        /****************************** METHODS ******************************/
        private void CountryCanBeAdded(string _country)
        {
            if (countries.AddCountry(_country))
            {

            }
            else
            {
                errorProvider.SetError(comboBoxSource, "This country already exists or doesn't respect the standards");
            }
        }


        private void SwapBox(string _string)
        {
            if (!countries.Countries.ContainsKey(_string))
                return;
            if (countries.Countries[_string] == false)
            {
            }
        }

        /******************************* EVENTS ******************************/

        /// <summary>
        /// This method is triggered when the shift right all button is pressed
        /// Shift all countries from comboBox to listBox and enable/disable buttons
        /// Update the current countries object
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void BtnShiftRightAll_Click(object sender, EventArgs e)
        {
            foreach (string country in comboBoxSource.Items)
            {
                listBoxTarget.Items.Add(country);
                countries.SetBoolAll(true);
            }
            comboBoxSource.Items.Clear();
            labelTarget.Enabled = true;
            listBoxTarget.Enabled = true;
            btnShiftRightAll.Enabled = false;
            btnShiftLeftAll.Enabled = true;

        }

        private void ComboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxTarget.SelectedIndex = -1;
            if (comboBoxSource.SelectedIndex >= 0 && comboBoxSource.SelectedIndex < comboBoxSource.Items.Count)
                btnShiftRight.Enabled = true;
            else
                btnShiftRight.Enabled = false;
        }

        private void BtnShiftRight_Click(object sender, EventArgs e)
        {
            string tempCountry;

            if (comboBoxSource.Text.Length != 0)
            {
                tempCountry = comboBoxSource.Text;
                if (countries.AddCountry(tempCountry, true, out string _errorMessage))
                    listBoxTarget.Items.Add(tempCountry);
                else
                    errorProvider.SetError(comboBoxSource, _errorMessage);
            }
            else
            {

            }
        }

        /// <summary>
        /// This method is triggered when the shift left all button is pressed
        /// Shift all countries from list to comboBox and enable/disable buttons
        /// Update the current countries object
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param
        private void BtnShiftLeftAll_Click(object sender, EventArgs e)
        {
            foreach (string country in listBoxTarget.Items)
            {
                comboBoxSource.Items.Add(country);
                countries.SetBoolAll(false);
            }
            listBoxTarget.Items.Clear();
            labelTarget.Enabled = false;
            listBoxTarget.Enabled = false;
            btnShiftRightAll.Enabled = true;
            btnShiftLeftAll.Enabled = false;
        }

        /// <summary>
        /// This method triggers 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxSource_Click(object sender, EventArgs e)
        {
            btnDown.Enabled = false;
            btnUp.Enabled = false;
            listBoxTarget.SelectedIndex = -1;
        }

        /// <summary>
        /// This method is triggered when the comboBox text changes
        /// Enable/disable buttons depending on the text.Lenght
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param
        private void ComboBoxSource_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (comboBoxSource.Text.Length != 0)
            {
                /// comboBoxSource.SelectedIndex = -1; //A voir
                listBoxTarget.SelectedIndex = -1; //A voir aussi
                btnShiftRightAll.Enabled = false;
                btnShiftRight.Enabled = true;
            }
            else
            {
                btnShiftRightAll.Enabled = true;
                btnShiftRight.Enabled = false;
            }
        }
    }
}
