using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace INPUT_VALIDATION
{
    public partial class Controles : Form
    {
        public const string nameCheck = "^[a-zA-Z]{1,30}$";
        public string name;
        public DateTime date;
        public float amount;
        public string zipcode;

        public Controles()
        {
            InitializeComponent();
        }

        private void textBox_has_input(object sender, CancelEventArgs e)
        {
            TextBox textToCheck = (TextBox)sender;

            if(string.IsNullOrWhiteSpace(textToCheck.Text))
            {
                e.Cancel = true;
                textToCheck.Focus();
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
