using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryCrateProduction_v1
{
    public class TypeList
    {
        #region ############### PROPEERTIES & CONSTRUCTOR ###############
        private List<Type> Types
        {
            get;
            set;
        }

        public TypeList()
        {
            Types = new List<Type>();
        }
        #endregion

        #region ############### METHODS ###############
        /// <summary>
        /// Makes the current object indexable
        /// </summary>
        /// <param name="_index">int</param>
        /// <returns>Type</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown by ElementAt method if index is out of range</exception>
        public Type this[int _index]
        {
            get => Types.ElementAt(_index);
        }

        /// <summary>
        /// Returns the lenght of the list
        /// </summary>
        public int Count
        {
            get => Types.Count;
        }

        /// <summary>
        /// Adds a new type to the current list
        /// If the type alreay exists in the list, return false. Otherwise returns true.
        /// </summary>
        /// <param name="_typeName">string</param>
        /// <returns>boolean</returns>
        /// <exception cref="ArgumentNullException">Thrown if the given argument is null</exception>
        public bool Add(string _typeName)
        {
            try
            {
                if (!IsUniqueType(_typeName))
                    return false;
                Types.Add(new Type(_typeName));
                return true;
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("The argument given in the Add method is null", e);
            }
        }

        /// <summary>
        /// Checks if a typeName already exists in the Types list
        /// </summary>
        /// <param name="_typeName">string</param>
        /// <returns>boolean</returns>
        /// <exception cref="ArgumentNullException">Thrown if the given argument is null</exception>
        private bool IsUniqueType(string _typeName)
        {
            try
            {
                return Types.Any(type => type.TypeName == _typeName);
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("The argument given in the IsUniqueType method is null", e);
            }
        }
        #endregion
    }
}