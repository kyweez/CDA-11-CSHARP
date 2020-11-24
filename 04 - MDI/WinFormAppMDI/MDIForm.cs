using System;
using System.Globalization;
using System.Windows.Forms;
using ClassLibraryLogin;
using ClassLibraryMDI;

namespace WinFormAppMDI
{
    public partial class MDIForm : Form
    {
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

        #region ############### EVENTS ###############
        public MDIForm()
        {
            CurrentSessionLogin = new Login();
            CurrentMdi = new MDI();
            InitializeComponent();
            timerStatusBar.Start();
            menuStrip.Items.Add("Coucou");
        }
        #endregion

        #region ############### METHODS ###############
        private void UpdateHMI()
        {
            toolStripStatusLabelCurrentDate.Text = CurrentMdi.CurrentDateTime.ToString(CultureInfo.CurrentCulture);
            toolStripStatusLabelLastApplication.Text = CurrentMdi.LastProgramLaunched.ToString();
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


    }
}
