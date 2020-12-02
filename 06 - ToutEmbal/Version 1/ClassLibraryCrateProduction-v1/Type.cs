using System;

namespace ClassLibraryCrateProduction_v1
{
   public class Type
    {
        #region ############### PROPERTIES AND CONSTRUCTORS ###############
        public string TypeName
        {
            get;
            private set;
        }

        /// <summary>
        /// Type constructor
        /// </summary>
        /// <param name="_typeName">string</param>
        /// <exception cref="ArgumentNullException">Thrown when the _typeName argument is null</exception>
        public Type(string _typeName)
        {
            if (_typeName == null)
                throw new ArgumentNullException("The given argument is null");
            TypeName = _typeName;
        }
        #endregion
    }
}