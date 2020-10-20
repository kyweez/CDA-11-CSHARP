using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INPUT_VALIDATION_V1
{
    public partial class Form1 : Form
    {
        private int coucou;
        public Form1()
        {
            InitializeComponent();
            coucou = 1;
        }

        public int Coucou
        {
            get => coucou;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
