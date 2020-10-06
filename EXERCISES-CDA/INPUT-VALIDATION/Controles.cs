using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INPUT_VALIDATION
{
    public partial class Controles : Form
    {
        public string name;
        public DateTime date;
        public float amount;
        public string zipcode;

        public Controles()
        {
            InitializeComponent();
        }

        private void textName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textName.Text))
            {
                e.Cancel = true;
                textName.Focus();
                ErrorProvider.Equals(textName, "Please insert your name");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.Equals(textName, null);
            }
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Coucou", "");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }

    }
}
