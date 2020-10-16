using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOOLS.ClassLibrary;

namespace INPUT_VALIDATION_V1
{
    public partial class InputValidation : Form
    {
        public InputValidation()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            List<TextBox> allFields = new List<TextBox>
            {
                tbName,
                tbDate,
                tbAmount,
                tbZipCode
            };

            if(!CheckData.FieldsAreFilled(allFields))
                btnValidate.Enabled = false;
            else
                btnValidate.Enabled = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            tbDate.Clear();
            tbAmount.Clear();
            tbZipCode.Clear();
        }
    }
}