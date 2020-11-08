using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanApp_v2
{
    public partial class LoanForm : Form
    {
        public LoanForm()
        {
            InitializeComponent();
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            CreateClientForm form = new CreateClientForm();
            form.ShowDialog();
        }

        private void btnModifyClient_Click(object sender, EventArgs e)
        {
            ModifyClientForm form = new ModifyClientForm();
            form.ShowDialog();
        }
    }
}
