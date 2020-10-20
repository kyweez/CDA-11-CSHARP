using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSINESS_CLASS_LIBRARY;

namespace LISTBOX
{
    public partial class ListBoxExo : Form
    {
        /***************************** ATTRIBUTES ****************************/
        private StudentList studentTab;

        /**************************** CONSTRUCTORS ***************************/
        public ListBoxExo()
        {
            InitializeComponent();
            studentTab = new StudentList();
        }

        /***************************** PROPERTIES ****************************/
        public StudentList StudentTab
        {
            get => studentTab;
        }

        /****************************** METHODS ******************************/
        
        /// <summary>
        ///     This method adds the input first name in the list box and in the studentTab
        ///     If the first name already extists, a dialog box appears and the adding is canceled
        /// </summary>
        private void AddFirstname()
        {
            if (listBox.FindStringExact(tbNewElement.Text) == ListBox.NoMatches)
            {
                btnEmptyList.Enabled = true;
                listBox.Enabled = true;
                tbIndexElement.Enabled = true;
                listBox.Items.Add(tbNewElement.Text);
                StudentTab.Create(new Person(tbNewElement.Text));
                tbNewElement.Clear();
                tbNewElement.Focus();
            }
            else
            {
                string title;
                string errorMessage;

                title = "Operation aborted";
                errorMessage = "This firstname is already in the list !";
                MessageBox.Show(errorMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAddFirstName.Enabled = false;
                tbNewElement.Focus();
            }

        }

        /// <summary>
        ///     This method clears the List box and the StudentTab list.
        /// </summary>
        private void ClearListBox()
        {
            listBox.Items.Clear();
            StudentTab.Clear();
            listBox.Enabled = false;
            tbIndexElement.Enabled = false;
            tbIndexElement.Clear();
            if (tbNewElement.Text.Length != 0)
            {
                btnAddFirstName.Enabled = true;
                btnAddFirstName.Focus();
            }
        }


        private void SelectIndex()
        {
            MessageBox.Show("Coucou SelectIndex");

        }


        /******************************* EVENTS ******************************/
        /// <summary>
        ///     This method is triggered when a text box changes
        ///     Enable or disable the associated button
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            errorProviderSelectIndex.Clear();
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length == 0)
            {
                if (sender == (object)tbNewElement)
                    btnAddFirstName.Enabled = false;
                if (sender == (object)tbIndexElement)
                    btnSelect.Enabled = false;
            }
            else
            {
                if (sender == (object)tbNewElement)
                    btnAddFirstName.Enabled = true;
                if (sender == (object)tbIndexElement)
                {
                    if (!int.TryParse(tbIndexElement.Text, out int result) || result <= 0)
                    {
                        string errorString;

                        errorString = $"Please insert a value between 0 and {StudentTab.Count - 1}";
                        errorProviderSelectIndex.SetError(tbIndexElement, errorString);
                    }
                    else
                    {
                        btnSelect.Enabled = true;
                    }
                }
            }
        }

        /// <summary>
        ///     This function is triggered when a button is clicked
        ///     Call method related to this button
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Button_Click(object sender, EventArgs e)
        {
            if (sender == (object)btnAddFirstName)
                AddFirstname();
            if (sender == (object)btnSelect)
                SelectIndex();
            if (sender == (object)btnEmptyList)
                ClearListBox();
        }


    }
}
