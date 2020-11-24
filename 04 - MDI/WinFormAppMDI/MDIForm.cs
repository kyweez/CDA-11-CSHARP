using System;
using System.Collections.Generic;
using System.Globalization;
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
        }
        #endregion


        #region ############### METHODS ###############

        private void InstanceNumberDictionaryCreation()
        {
            foreach (ProgramNameEnum name in (ProgramNameEnum[])Enum.GetValues(typeof(ProgramNameEnum)))
            {
                if (name != 0)
                    instanceNumberDictionnary.Add(name.ToString(), 0);
            }
            instanceNumberDictionnary.Add("Total", 0);
        }

        private int GetInstanceNumber(ProgramNameEnum programName)
        {
            instanceNumberDictionnary["Total"]++;
            return ++instanceNumberDictionnary[programName.ToString()];
        }

        private void UpdateHMI()
        {
            toolStripStatusLabelCurrentDate.Text = CurrentMdi.CurrentDateTime.ToString(CultureInfo.CurrentCulture);
            toolStripStatusLabelLastApplication.Text = $"Last program launched : {CurrentMdi.GetLastProgramLaunchedDescription()}";
            //toolStripStatusLabelLastApplication.Text = $"Last program launched : {Enum. CurrentMdi.LastProgramLaunched}";
        }
        #endregion

        #region ############### EVENTS ###############
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

        #region ############### MENU EVENTS ###############

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adder calculator = new Adder(GetInstanceNumber(ProgramNameEnum.Calculator));
            calculator.MdiParent = this;
            calculator.Show();
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.Calculator);
        }

        private void inputValidationV1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputValidationForm1 inputValidationForm1 = new InputValidationForm1(GetInstanceNumber(ProgramNameEnum.InputValidation_v1));
            inputValidationForm1.MdiParent = this;
            inputValidationForm1.Show();
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.InputValidation_v1);
        }

        private void inputValidationV2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputValidationForm2 inputValidationForm2 = new InputValidationForm2(GetInstanceNumber(ProgramNameEnum.InputValidation_v2));
            inputValidationForm2.MdiParent = this;
            inputValidationForm2.Show();
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.InputValidation_v2);
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckBoxForm checkBoxForm = new CheckBoxForm(GetInstanceNumber(ProgramNameEnum.CheckBox));
            checkBoxForm.MdiParent = this;
            checkBoxForm.Show();
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.CheckBox);
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBoxForm listBoxForm = new ListBoxForm(GetInstanceNumber(ProgramNameEnum.ListBox));
            listBoxForm.MdiParent = this;
            listBoxForm.Show();
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.ListBox);
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComboBoxForm comboBoxForm = new ComboBoxForm(GetInstanceNumber(ProgramNameEnum.ComboBox));
            comboBoxForm.MdiParent = this;
            comboBoxForm.Show();
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.ComboBox);
        }

        private void scrollingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScrollingForm1 scrollingForm1 = new ScrollingForm1(GetInstanceNumber(ProgramNameEnum.Scrolling_v1));
            scrollingForm1.MdiParent = this;
            scrollingForm1.Show();
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.Scrolling_v1);
        }

        private void loanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoanForm1 loanForm1 = new LoanForm1(GetInstanceNumber(ProgramNameEnum.Loan_v1));
            loanForm1.MdiParent = this;
            loanForm1.Show();
            CurrentMdi.UpdateLastProgramLaunched(ProgramNameEnum.Loan_v1);
        }
        #endregion

        #region ############### DISPLAY EVENTS ###############

        #endregion

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
    }
}
