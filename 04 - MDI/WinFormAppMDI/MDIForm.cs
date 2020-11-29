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
        /// Increment the programName value and returns it
        /// </summary>
        /// <param name="programName">ProgramNameEnum</param>
        /// <returns>int</returns>
        private int GetInstanceNumber(ProgramNameEnum programName)
        {
            return ++instanceNumberDictionnary[programName.ToString()];
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
        private void ChildClosed(object sender, FormClosedEventArgs e)
        {
            if (MdiChildren.Length == 1)
            {
                toolStripDisplaySeparator.Visible = false;
                closeAllToolStripMenuItem.Enabled = false;
            }
        }

        private void InputForm_CancelInput()
        {
            checkBoxToolStripMenuItem.Enabled = true;
            checkBoxToolStripMenuItem.Text = "Check box";
        }

        private void InputForm_ValidInput(string _str)
        {
            CheckBoxFormLaunch(_str);
        }

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

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timerStatusBar_Tick(object sender, EventArgs e)
        {
            CurrentMdi.UpdateCurrentDateTime();
            UpdateHMI();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout();
        }

        #endregion

        #region ############### MENU EVENT METHODS ###############
        private void CalculatorProgramLaunch()
        {
            Adder calculator = new Adder(GetInstanceNumber(ProgramNameEnum.Calculator));
            ShowForm(calculator);
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.Calculator);
            toolStripDisplaySeparator.Visible = true;
        }

        private void CheckBoxFormLaunch(string _str)
        {
            CheckBoxForm checkBoxForm = new CheckBoxForm(GetInstanceNumber(ProgramNameEnum.CheckBox), _str);
            ShowForm(checkBoxForm);
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.CheckBox);
            toolStripDisplaySeparator.Visible = true;
        }

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

        private void ComboBoxProgramLaunch()
        {
            ComboBoxForm comboBoxForm = new ComboBoxForm(GetInstanceNumber(ProgramNameEnum.ComboBox));
            ShowForm(comboBoxForm);
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.ComboBox);
            toolStripDisplaySeparator.Visible = true;
        }

        private void InputValidationV1ProgramLaunch()
        {
            InputValidationForm1 inputValidationForm1 = new InputValidationForm1(GetInstanceNumber(ProgramNameEnum.InputValidation_v1));
            ShowForm(inputValidationForm1);
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.InputValidation_v1);
            toolStripDisplaySeparator.Visible = true;
        }

        private void InputValidationV2ProgramLaunch()
        {
            InputValidationForm2 inputValidationForm2 = new InputValidationForm2(GetInstanceNumber(ProgramNameEnum.InputValidation_v2));
            ShowForm(inputValidationForm2);
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.InputValidation_v2);
            toolStripDisplaySeparator.Visible = true;
        }

        private void ListBoxProgramLaunch()
        {
            ListBoxForm listBoxForm = new ListBoxForm(GetInstanceNumber(ProgramNameEnum.ListBox));
            ShowForm(listBoxForm);
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.ListBox);
            toolStripDisplaySeparator.Visible = true;
        }

        private void LoanProgramLaunch()
        {
            LoanForm1 loanForm1 = new LoanForm1(GetInstanceNumber(ProgramNameEnum.Loan_v1));
            ShowForm(loanForm1);
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.Loan_v1);
            toolStripDisplaySeparator.Visible = true;
        }

        private void ScrollingProgramLaunch()
        {
            ScrollingForm1 scrollingForm1 = new ScrollingForm1(GetInstanceNumber(ProgramNameEnum.Scrolling_v1));
            ShowForm(scrollingForm1);
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.Scrolling_v1);
            toolStripDisplaySeparator.Visible = true;
        }
        #endregion

        #region ############### MENU EVENTS ###############
        private void Calculator_Click(object sender, EventArgs e)
        {
            CalculatorProgramLaunch();
        }

        private void CheckBox_Click(object sender, EventArgs e)
        {
            CheckBoxProgramLaunch();
        }

        private void ComboBox_Click(object sender, EventArgs e)
        {
            ComboBoxProgramLaunch();
            toolStripDisplaySeparator.Visible = true;
        }

        private void InputValidationV1_Click(object sender, EventArgs e)
        {
            InputValidationV1ProgramLaunch();
        }

        private void InputValidationV2_Click(object sender, EventArgs e)
        {
            InputValidationV2ProgramLaunch();
        }

        private void Loan_Click(object sender, EventArgs e)
        {
            LoanProgramLaunch();
            toolStripDisplaySeparator.Visible = true;
        }

        private void ListBox_Click(object sender, EventArgs e)
        {
            ListBoxProgramLaunch();
            toolStripDisplaySeparator.Visible = true;
        }

        private void Scrolling_Click(object sender, EventArgs e)
        {
            ScrollingProgramLaunch();
            toolStripDisplaySeparator.Visible = true;
        }
        #endregion

        #region ############### DISPLAY EVENTS ###############
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildrenForms();
        }
        #endregion

        private void toolStripSplitButtonLastItem_ButtonClick(object sender, EventArgs e)
        {
            toolStripSplitButtonGraphicalObjects.ShowDropDown();
        }
    }
}
