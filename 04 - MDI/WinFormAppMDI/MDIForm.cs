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
        }
        #endregion

        #region ############### METHODS ###############
        private void CloseAllChildrenForms()
        {
            foreach (Form frm in MdiChildren)
                frm.Close();
        }

        private void InstanceNumberDictionaryCreation()
        {
            foreach (ProgramNameEnum name in (ProgramNameEnum[])Enum.GetValues(typeof(ProgramNameEnum)))
            {
                if (name != 0)
                    instanceNumberDictionnary.Add(name.ToString(), 0);
            }
        }

        private int GetInstanceNumber(ProgramNameEnum programName)
        {
            return ++instanceNumberDictionnary[programName.ToString()];
        }

        private void Login_AuthenticationSuccess()
        {
            foreach (ToolStripMenuItem item in menuStrip.Items)
                item.Enabled = true;
            toolStripButtonLogin.Enabled = false;
            logInToolStripMenuItem.Enabled = false;
            disconnectToolStripMenuItem.Enabled = true;
            toolStripSplitButtonLastItem.Visible = true;
            toolStripSplitButtonLastItem.Enabled = true;
        }

        private void UpdateHMI()
        {
            toolStripStatusLabelCurrentDate.Text = CurrentMdi.CurrentDateTime.ToString(CultureInfo.CurrentCulture);
            toolStripStatusLabelLastApplication.Text = $"Last program launched : {CurrentMdi.GetLastProgramLaunchedDescription()}";
        }
        #endregion

        #region ############### EVENTS ###############
        void ChildClosed(object sender, FormClosedEventArgs e)
        {
            toolStripDisplaySeparator.Visible = false;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(CurrentSessionLogin);
            loginForm.ShowDialog();
            if (loginForm.CurrentLogin.IsValidLogin)
            {
                Login_AuthenticationSuccess();
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

        #endregion

        #region ############### MENU EVENT METHODS ###############
        private void CheckBoxProgramLaunch(int _instanceNumber, string _str)
        {
            CheckBoxForm checkBoxForm = new CheckBoxForm(_instanceNumber, _str);
            checkBoxForm.MdiParent = this;
            checkBoxForm.FormClosed += ChildClosed;
            checkBoxForm.Show();
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.CheckBox);
        }

        private void ListBoxProgramLaunch()
        {
            ListBoxForm listBoxForm = new ListBoxForm(GetInstanceNumber(ProgramNameEnum.ListBox));
            listBoxForm.MdiParent = this;
            listBoxForm.FormClosed += ChildClosed;
            listBoxForm.Show();
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.ListBox);
        }

        private void ComboBoxProgramLaunch()
        {
            ComboBoxForm comboBoxForm = new ComboBoxForm(GetInstanceNumber(ProgramNameEnum.ComboBox));
            comboBoxForm.MdiParent = this;
            comboBoxForm.FormClosed += ChildClosed;
            comboBoxForm.Show();
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.ComboBox);
        }

        private void ScrollingProgramLaunch()
        {
            ScrollingForm1 scrollingForm1 = new ScrollingForm1(GetInstanceNumber(ProgramNameEnum.Scrolling_v1));
            scrollingForm1.MdiParent = this;
            scrollingForm1.FormClosed += ChildClosed;
            scrollingForm1.Show();
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.Scrolling_v1);
        }

        private void LoanProgramLaunch()
        {
            LoanForm1 loanForm1 = new LoanForm1(GetInstanceNumber(ProgramNameEnum.Loan_v1));
            loanForm1.MdiParent = this;
            loanForm1.FormClosed += ChildClosed;
            loanForm1.Show();
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.Loan_v1);
        }
        #endregion

        #region ############### MENU EVENTS ###############

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adder calculator = new Adder(GetInstanceNumber(ProgramNameEnum.Calculator));
            calculator.MdiParent = this;
            calculator.FormClosed += ChildClosed;
            calculator.Show();
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.Calculator);
            toolStripDisplaySeparator.Visible = true;
        }

        private void inputValidationV1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputValidationForm1 inputValidationForm1 = new InputValidationForm1(GetInstanceNumber(ProgramNameEnum.InputValidation_v1));
            inputValidationForm1.MdiParent = this;
            inputValidationForm1.FormClosed += ChildClosed;
            inputValidationForm1.Show();
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.InputValidation_v1);
            toolStripDisplaySeparator.Visible = true;
        }

        private void inputValidationV2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputValidationForm2 inputValidationForm2 = new InputValidationForm2(GetInstanceNumber(ProgramNameEnum.InputValidation_v2));
            inputValidationForm2.MdiParent = this;
            inputValidationForm2.FormClosed += ChildClosed;
            inputValidationForm2.Show();
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.InputValidation_v2);
            toolStripDisplaySeparator.Visible = true;
        }

        private void stripAndMenuCheckBox_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm(GetInstanceNumber(ProgramNameEnum.CheckBox));
            inputForm.MdiParent = this;
            inputForm.FormClosed += ChildClosed;
            inputForm.ValidInput += InputForm_ValidInput;
            inputForm.CancelInput += InputForm_CancelInput;
            inputForm.Show();
            toolStripDisplaySeparator.Visible = true;
        }

        private void InputForm_CancelInput()
        {
            instanceNumberDictionnary[ProgramNameEnum.CheckBox.ToString()]--;
        }

        private void InputForm_ValidInput(int instanceNumber, string input)
        {
            CheckBoxProgramLaunch(instanceNumber, input);

        }

        private void stripAndMenuListBox_Click(object sender, EventArgs e)
        {
            ListBoxProgramLaunch();
            toolStripDisplaySeparator.Visible = true;
        }

        private void stripAndMenuComboBox_Click(object sender, EventArgs e)
        {
            ComboBoxProgramLaunch();
            toolStripDisplaySeparator.Visible = true;
        }

        private void stripAndMenuScrolling_Click(object sender, EventArgs e)
        {
            ScrollingProgramLaunch();
            toolStripDisplaySeparator.Visible = true;
        }

        private void stripAndMenuLoan_Click(object sender, EventArgs e)
        {
            LoanProgramLaunch();
            toolStripDisplaySeparator.Visible = true;
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildrenForms();
            foreach (ToolStripMenuItem item in menuStrip.Items)
                item.Enabled = false;
            menuStrip.Items[0].Enabled = true;
            toolStripButtonLogin.Enabled = true;
            logInToolStripMenuItem.Enabled = true;
            disconnectToolStripMenuItem.Enabled = false;
            toolStripSplitButtonLastItem.Visible = false;
            toolStripSplitButtonLastItem.Enabled = false;
            CurrentSessionLogin.Disconnect();
            instanceNumberDictionnary.Clear();
            InstanceNumberDictionaryCreation();
            CurrentMdi.UpdateLastProgramLaunched(0);
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
    }
}
