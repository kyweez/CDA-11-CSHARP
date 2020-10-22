using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBoxEventClassLibrary
{
    public class ListBoxItemEventArgs : EventArgs
    {
        private int index;
        public ListBoxItemEventArgs(int index)
        {
            this.index = index;
        }
        public int Index
        {
            get
            {
                return this.index;
            }
        }
    }
}
