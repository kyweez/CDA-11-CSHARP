using ClassLibraryCrateProduction_v1.Exceptions;
using System;

namespace ClassLibraryCrateProduction_v1
{
    public class Crate
    {
        #region ############### PROPERTIES & CONSTRUCTOR ###############
        public Type CrateType
        {
            get;
            private set;
        }

        public bool IsFaulty
        {
            get;
            private set;
        }

        /// <summary>
        /// Crate constructor
        /// </summary>
        /// <param name="_type">Type</param>
        /// <param name="_typeList">TypeList</param>
        /// <exception cref="ArgumentNullException">Thrown when a given argument is null</exception>
        /// <exception cref="ImpossibleCrateInstanciation">Thrown when the given type isn't contained in the given typeList</exception>
        /// <exception cref="Exception">Thrown if the Contains method catched an exception</exception>
        public Crate(Type _type, TypeList _typeList)
        {
            if (_type == null || _typeList == null)
                throw new ArgumentNullException("The type argument given in the Crate constructor is null");
            try
            {
                if (!_typeList.Contains(_type))
                    throw new ImpossibleCrateInstanciation("The type given as an argument doesn't exist in the typelist argument");
                CrateType = _type;
                IsFaulty = false;
            }
            catch (Exception e)
            {
                throw new Exception("Impossible crate instanciation", e);
            }
        }
        #endregion
    }
}