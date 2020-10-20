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
        private void AddFirstname()
        {
            if (listBox.FindStringExact(tbNewElement.Text) == ListBox.NoMatches)
            {
                listBox.Items.Add(tbNewElement.Text);
                StudentTab.Create(new Person(tbNewElement.Text));
                tbNewElement.Clear();
            }
            else
            {
                string title;
                string errorMessage;

                title = "Operation aborted";
                errorMessage = "This firstname is already in the list !";
                MessageBox.Show(errorMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAddFirstName.Enabled = false;
            }

        }

        private void SelectIndex()
        {
            MessageBox.Show("Coucou SelectIndex");

        }

        private void ClearListBox()
        {
            MessageBox.Show("Coucou ClearListBox");

        }
        /******************************* EVENTS ******************************/
        /// <summary>
        ///     This method is triggered when a text box changes
        ///     Enable or disable the associated button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
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
                    btnSelect.Enabled = true;
            }
        }

        /// <summary>
        ///     This function is triggered when a button is clicked
        ///     Call method related to this button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
