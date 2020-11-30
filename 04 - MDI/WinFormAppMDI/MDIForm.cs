using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryLogin;
using ClassLibraryMDI;
using WinFormAppCalculator;
using WinFormAppCheckBox;
using WinFormAppComboBox;
using WinFormAppInputValidation_v1;
using WinFormAppInputValidation_v2;
using WinFormAppListBox;
using WinFormAppLoan_v1;
using WinFormAppScrolling_v1;

namespace WinFormAppMDI
{
    public partial class MDIForm : Form
    {
        private static Dictionary<string, int> instanceNumberDictionnary;

        #region ############### PROPERTIES ###############
        private Login CurrentSessionLogin
        {
            get;
            set;
        }

        private MDI CurrentMdi
        {
            get;
            set;
        }
        #endregion

        #region ############### CONSTRUCTOR ###############
        public MDIForm()
        {
            CurrentSessionLogin = new Login();
            CurrentMdi = new MDI();
            instanceNumberDictionnary = new Dictionary<string, int>();
            InitializeComponent();
            timerStatusBar.Start();
            InstanceNumberDictionaryCreation();
            toolStripDisplaySeparator.Visible = false;
            closeAllToolStripMenuItem.Enabled = false;
        }
        #endregion

        #region ############### METHODS ###############
        /// <summary>
        /// Close all children forms
        /// </summary>
        private void CloseAllChildrenForms()
        {
            foreach (Form frm in MdiChildren)
                frm.Close();
            closeAllToolStripMenuItem.Enabled = false;
        }

        /// <summary>
        /// Increment the programName value and returns it
        /// </summary>
        /// <param name="programName">ProgramNameEnum</param>
        /// <returns>int</returns>
        private int GetInstanceNumber(ProgramNameEnum programName)
        {
            return ++instanceNumberDictionnary[programName.ToString()];
        }

        /// <summary>
        /// Complete the dictionnary of the instanceNumber depending on the ProgramNameEnum
        /// </summary>
        private void InstanceNumberDictionaryCreation()
        {
            foreach (ProgramNameEnum name in (ProgramNameEnum[])Enum.GetValues(typeof(ProgramNameEnum)))
            {
                if (name != 0)
                    instanceNumberDictionnary.Add(name.ToString(), 0);
            }
        }

        /// <summary>
        /// Enable and disable items 
        /// </summary>
        private void Login_AuthenticationSuccess()
        {
            foreach (ToolStripMenuItem item in menuStrip.Items)
                item.Enabled = true;
            logInToolStripMenuItem.Enabled = false;
            disconnectToolStripMenuItem.Enabled = true;
            toolStripSplitButtonGraphicalObjects.Visible = true;
            toolStripSplitButtonGraphicalObjects.Enabled = true;
            toolStripButtonLogin.Text = "Log out";
        }

        /// <summary>
        /// Close all forms and disconnect the current session
        /// </summary>
        private void Logout()
        {
            CloseAllChildrenForms();
            foreach (ToolStripMenuItem item in menuStrip.Items)
                item.Enabled = false;
            menuStrip.Items[0].Enabled = true;
            toolStripButtonLogin.Enabled = true;
            logInToolStripMenuItem.Enabled = true;
            disconnectToolStripMenuItem.Enabled = false;
            toolStripSplitButtonGraphicalObjects.Visible = false;
            toolStripSplitButtonGraphicalObjects.Enabled = false;
            CurrentSessionLogin.Disconnect();
            instanceNumberDictionnary.Clear();
            InstanceNumberDictionaryCreation();
            CurrentMdi.UpdateLastProgramLaunched(0);
            toolStripButtonLogin.Text = "Log in";
        }

        /// <summary>
        /// Make the input form a new children of the current form, subscribe to the ChildClosed event and show the input form
        /// </summary>
        /// <param name="_object">Form</param>
        private void ShowForm(Form _object)
        {
            _object.MdiParent = this;
            _object.FormClosed += ChildClosed;
            _object.Show();
            closeAllToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// Update the statusBar
        /// </summary>
        private void UpdateHMI()
        {
            toolStripStatusLabelCurrentDate.Text = CurrentMdi.CurrentDateTime.ToString(CultureInfo.CurrentCulture);
            toolStripStatusLabelLastApplication.Text = $"Last program launched : {CurrentMdi.GetLastProgramLaunchedDescription()}";
        }
        #endregion

        #region ############### EVENTS ###############

        /// <summary>
        /// Triggered when a chil form is closed
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">FormClosedEventArgs</param>
        private void ChildClosed(object sender, FormClosedEventArgs e)
        {
            if (MdiChildren.Length == 1)
            {
                toolStripDisplaySeparator.Visible = false;
                closeAllToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// Triggered when the disconnect menu item is clicked. Log out
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void DisconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout();
        }

        /// <summary>
        /// Triggered when the InputForm cancel event is triggered
        /// </summary>
        private void InputForm_CancelInput()
        {
            checkBoxToolStripMenuItem.Enabled = true;
            checkBoxToolStripMenuItem.Text = "Check box";
        }

        /// <summary>
        /// Triggered when the InputForm valid event is triggered
        /// </summary>
        private void InputForm_ValidInput(string _str)
        {
            CheckBoxFormLaunch(_str);
        }

        /// <summary>
        /// Triggered when the Login (or Logout) button is pressed
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void LoginLogout_Click(object sender, EventArgs e)
        {
            if (toolStripButtonLogin.Text == "Log in")
            {
                LoginForm loginForm = new LoginForm(CurrentSessionLogin);
                loginForm.ShowDialog();
                if (loginForm.CurrentLogin.IsValidConnection)
                {
                    Login_AuthenticationSuccess();
                }
            }
            else
            {
                Logout();
            }
        }

        /// <summary>
        /// Triggered when the quit button is pressed. Close the current form.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Triggered on each timer tick. Update time and HMI
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void TimerStatusBar_Tick(object sender, EventArgs e)
        {
            CurrentMdi.UpdateCurrentDateTime();
            UpdateHMI();
        }

        /// <summary>
        /// Triggered when the Graphical object button is clicked. Show the dropdown
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void ToolStripSplitButtonLastItem_ButtonClick(object sender, EventArgs e)
        {
            toolStripSplitButtonGraphicalObjects.ShowDropDown();
        }
        #endregion

        #region ############### MENU EVENT METHODS ###############

        /// <summary>
        /// Launches the Calculator program
        /// </summary>
        private void CalculatorProgramLaunch()
        {
            Adder calculator = new Adder(GetInstanceNumber(ProgramNameEnum.Calculator));
            ShowForm(calculator);
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.Calculator);
            toolStripDisplaySeparator.Visible = true;
        }

        /// <summary>
        /// Launches the Checkbox form
        /// </summary>
        /// <param name="_str">string</param>
        private void CheckBoxFormLaunch(string _str)
        {
            CheckBoxForm checkBoxForm = new CheckBoxForm(GetInstanceNumber(ProgramNameEnum.CheckBox), _str);
            ShowForm(checkBoxForm);
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.CheckBox);
            toolStripDisplaySeparator.Visible = true;
        }

        /// <summary>
        /// Launches the Checkbox program
        /// </summary>
        private void CheckBoxProgramLaunch()
        {
            InputForm inputForm = new InputForm();
            ShowForm(inputForm);
            inputForm.ValidInput += InputForm_ValidInput;
            inputForm.CancelInput += InputForm_CancelInput;
            toolStripDisplaySeparator.Visible = true;
            checkBoxToolStripMenuItem.Enabled = false;
            checkBoxToolStripMenuItem.Text = "Check box (input form in progress)";
        }

        /// <summary>
        /// Launches the Combo box program
        /// </summary>
        private void ComboBoxProgramLaunch()
        {
            ComboBoxForm comboBoxForm = new ComboBoxForm(GetInstanceNumber(ProgramNameEnum.ComboBox));
            ShowForm(comboBoxForm);
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.ComboBox);
            toolStripDisplaySeparator.Visible = true;
        }

        /// <summary>
        /// Launches the Input validation v1 program
        /// </summary>
        private void InputValidationV1ProgramLaunch()
        {
            InputValidationForm1 inputValidationForm1 = new InputValidationForm1(GetInstanceNumber(ProgramNameEnum.InputValidation_v1));
            ShowForm(inputValidationForm1);
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.InputValidation_v1);
            toolStripDisplaySeparator.Visible = true;
        }

        /// <summary>
        /// Launches the Input validation v2 program
        /// </summary>
        private void InputValidationV2ProgramLaunch()
        {
            InputValidationForm2 inputValidationForm2 = new InputValidationForm2(GetInstanceNumber(ProgramNameEnum.InputValidation_v2));
            ShowForm(inputValidationForm2);
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.InputValidation_v2);
            toolStripDisplaySeparator.Visible = true;
        }

        /// <summary>
        /// Launches the ListBox program
        /// </summary>
        private void ListBoxProgramLaunch()
        {
            ListBoxForm listBoxForm = new ListBoxForm(GetInstanceNumber(ProgramNameEnum.ListBox));
            ShowForm(listBoxForm);
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.ListBox);
            toolStripDisplaySeparator.Visible = true;
        }

        /// <summary>
        /// Launches the Loan program
        /// </summary>
        private void LoanProgramLaunch()
        {
            LoanForm1 loanForm1 = new LoanForm1(GetInstanceNumber(ProgramNameEnum.Loan_v1));
            ShowForm(loanForm1);
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.Loan_v1);
            toolStripDisplaySeparator.Visible = true;
        }

        /// <summary>
        /// Launches the Scrolling program
        /// </summary>
        private void ScrollingProgramLaunch()
        {
            ScrollingForm1 scrollingForm1 = new ScrollingForm1(GetInstanceNumber(ProgramNameEnum.Scrolling_v1));
            ShowForm(scrollingForm1);
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.Scrolling_v1);
            toolStripDisplaySeparator.Visible = true;
        }
        #endregion

        #region ############### MENU EVENTS ###############
        /// <summary>
        /// Triggered when the calculator menu item is clicked
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Calculator_Click(object sender, EventArgs e)
        {
            CalculatorProgramLaunch();
        }

        /// <summary>
        /// Triggered when the checkbox menu item is clicked
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void CheckBox_Click(object sender, EventArgs e)
        {
            CheckBoxProgramLaunch();
        }

        /// <summary>
        /// Triggered when the combobox menu item is clicked
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void ComboBox_Click(object sender, EventArgs e)
        {
            ComboBoxProgramLaunch();
            toolStripDisplaySeparator.Visible = true;
        }

        /// <summary>
        /// Triggered when the InputValidation v1 menu item is clicked
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void InputValidationV1_Click(object sender, EventArgs e)
        {
            InputValidationV1ProgramLaunch();
        }

        /// <summary>
        /// Triggered when the InputValidation v2 menu item is clicked
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void InputValidationV2_Click(object sender, EventArgs e)
        {
            InputValidationV2ProgramLaunch();
        }

        /// <summary>
        /// Triggered when the Looan menu item is clicked
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Loan_Click(object sender, EventArgs e)
        {
            LoanProgramLaunch();
            toolStripDisplaySeparator.Visible = true;
        }

        /// <summary>
        /// Triggered when the ListBox menu item is clicked
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void ListBox_Click(object sender, EventArgs e)
        {
            ListBoxProgramLaunch();
            toolStripDisplaySeparator.Visible = true;
        }

        /// <summary>
        /// Triggered when the Scrolling menu item is clicked
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Scrolling_Click(object sender, EventArgs e)
        {
            ScrollingProgramLaunch();
            toolStripDisplaySeparator.Visible = true;
        }
        #endregion

        #region ############### DISPLAY EVENTS ###############

        /// <summary>
        /// Triggered when the cascade menu item is clicked
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        /// <summary>
        /// Triggered when the Close all menu item is clicked
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildrenForms();
        }

        /// <summary>
        /// Triggered when the horizontal menu item is clicked
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void HorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        /// <summary>
        /// Triggered when the vertical menu item is clicked
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void VerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        #endregion
    }
}