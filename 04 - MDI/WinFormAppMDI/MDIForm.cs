using System;
using System.Windows.Forms;
using ClassLibraryLogin;

namespace WinFormAppMDI
{
    public partial class MDIForm : Form
    {
        Login login;

        public MDIForm()
        {
            login = new Login();
            login.AuthenticationSuccess += Login_AuthenticationSuccess;
            InitializeComponent();

        }

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
            LoginForm loginForm = new LoginForm(login);
            loginForm.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
