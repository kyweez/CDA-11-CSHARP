using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTILS
{
    public static class TextBoxControls
    {
        public static bool TextBoxIsEmpty(TextBox _textBox)
        {
            return (_textBox.Text == null || _textBox.Text.Length == 0);
        }
    }
}
