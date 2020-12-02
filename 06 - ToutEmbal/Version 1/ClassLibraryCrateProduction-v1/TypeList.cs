using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCrateProduction_v1
{
    public class TypeList : List<Type>
    {
        public List<Type> Types
        {
            get;
            private set;
        } 
    }
}
