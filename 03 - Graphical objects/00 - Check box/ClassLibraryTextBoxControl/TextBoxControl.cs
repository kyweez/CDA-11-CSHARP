using System.Windows.Forms;

namespace ClassLibraryTextBoxControl
{
    public static class TextBoxControl
    {
        public static bool TextBoxIsEmpty(TextBox _textBox)
        {
            return (_textBox.Text == null || _textBox.Text.Length == 0);
        }
    }
}