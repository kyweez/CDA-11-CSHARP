using ClassLibraryStudent;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormAppListBox
{
    public partial class ListBoxForm : Form
    {
        #region ############### FIELDS ###############
        private StudentList studentTab;
        #endregion

        #region ############### CONSTRUCTORS ###############
        public ListBoxForm()
        {
            InitializeComponent();
            studentTab = new StudentList();
        }
        #endregion

        #region ############### PROPERTIES ###############
        public StudentList StudentTab
        {
            get => studentTab;
        }
        #endregion

        #region ############### METHODS ###############
        /// <summary>
        ///     This method adds the input first name in the list box and in the studentTab
        ///     If the first name already extists, a dialog box appears and the adding is canceled
        /// </summary>
        private void AddFirstname()
        {
            string title = "Operation aborted";
            string errorMessage;

            if (!Regex.IsMatch(tbNewElement.Text, @"^[a-zA-Z]+([\-\' ][a-zA-Z]+)*$"))
            {
                errorMessage = "This is not a valid name";
                MessageBox.Show(errorMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAddFirstName.Enabled = false;
                tbNewElement.Focus();
            }
            else if (!(listBox.FindStringExact(tbNewElement.Text) == ListBox.NoMatches))
            {
                errorMessage = "This firstname is already in the list !";
                MessageBox.Show(errorMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAddFirstName.Enabled = false;
                tbNewElement.Focus();
            }
            else
            {
                btnEmptyList.Enabled = true;
                listBox.Enabled = true;
                tbIndexElement.Enabled = true;
                listBox.Items.Add(tbNewElement.Text);
                StudentTab.Create(new Person(tbNewElement.Text));
                tbNewElement.Clear();
                tbNewElement.Focus();
                tbItemsCount.Text = StudentTab.Count.ToString();
            }
        }

        /// <summary>
        ///     Clear information in textboxes 
        /// </summary>
        private void ClearInformation()
        {
            tbSelectedIndex.Clear();
            tbText.Clear();
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
            btnEmptyList.Enabled = false;
            if (tbNewElement.Text.Length != 0)
            {
                btnAddFirstName.Enabled = true;
                btnAddFirstName.Focus();
            }
            tbItemsCount.Clear();
            ClearInformation();
        }

        /// <summary>
        ///     This method displays the information related to the selected item in the list Box
        /// </summary>
        /// <param name="index">int</param>
        private void DisplayInformation(int index)
        {
            tbSelectedIndex.Text = index.ToString();
            tbText.Text = StudentTab[index].FirstName;
        }

        /// <summary>
        ///     This method selects the given index. If it doesn't exists an error message appears
        /// </summary>
        private void SelectIndex()
        {
            if (!int.TryParse(tbIndexElement.Text, out int index) || index < 0 || index >= StudentTab.Count)
            {
                string title;
                string errorMessage;
                listBox.SelectedIndex = -1;
                title = "Operation aborted";
                errorMessage = $"The value must be betweeen 0 and {StudentTab.Count - 1}";

                MessageBox.Show(errorMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAddFirstName.Enabled = false;
                tbIndexElement.Focus();
            }
            else
                listBox.SelectedIndex = index;
        }
        #endregion

        #region ############### EVENTS ###############
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

        /// <summary>
        ///     This method is triggered when the selected index in the list box changes
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex >= 0 && listBox.SelectedIndex < StudentTab.Count)
                DisplayInformation(listBox.SelectedIndex);
            else
                ClearInformation();
        }

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
                {
                    if (!Regex.IsMatch(tbNewElement.Text, @"^[a-zA-Z]+([\-\' ][a-zA-Z]+)*$"))
                    {
                        errorProviderSelectIndex.SetError(tbNewElement, "Invalid first name");
                        btnAddFirstName.Enabled = false;
                    }
                    else
                        btnAddFirstName.Enabled = true;
                }
                if (sender == (object)tbIndexElement)
                {
                    if (!int.TryParse(tbIndexElement.Text, out int result) || result < 0)
                    {
                        string errorString = $"Please insert a value between 0 and {StudentTab.Count - 1}";
                        errorProviderSelectIndex.SetError(tbIndexElement, errorString);
                    }
                    else
                        btnSelect.Enabled = true;
                }
            }
        }
    }
    #endregion
}