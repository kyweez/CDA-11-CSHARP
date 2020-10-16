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
using INPUT_VALIDATION.UtilsLibrary;

namespace INPUT_VALIDATION
{
    public partial class Controles : Form
    {
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
            textName.Clear();
            textDate.Clear();
            textAmount.Clear();
            textZipCode.Clear();
        }

        private void textBox_Changed(object sender, EventArgs e)
        {
            List<TextBox> allFields = new List<TextBox>
            {
                textName,
                textDate,
                textAmount,
                textZipCode
            };

            if (!SecurityCheck.FieldsAreFilled(allFields))
                buttonValidate.Enabled = false;
            else
                buttonValidate.Enabled = true;
        }

    }
}
