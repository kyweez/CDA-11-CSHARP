using LoanClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LoanListClassLibrary
{
    [Serializable]
    public class LoanList
    {
        private const string databaseFile = "./LoanList.json";

        #region ********** PROPERTIES **********
        public Dictionary<int, Loan> LoansDB
        {
            get; private set;
        }
        public int LastIndex
        {
            get; private set;
        }
        #endregion

        #region ********** CONSTRUCTORS **********
        public LoanList()
        {
            if (File.Exists(databaseFile))
            {
                LoansDB = JsonSerializer.Deserialize<Dictionary<int, Loan>>(File.ReadAllText(databaseFile));
                LastIndex = LoansDB.Keys.Last();
            }
            else
            {
                LoansDB = new Dictionary<int, Loan>();
                LastIndex = 0;
            }

        }
        #endregion

        #region ********** METHODS **********
        /// <summary>
        /// Creates a new entry in the database
        /// </summary>
        /// <param name="_loan">Loan</param>
        /// <exception cref="ArgumentNullException">If the Loan object given as an argument is null</exception>
        /// <exception cref="OverflowException">The loan database is full</exception>
        /// <exception cref="ArgumentException">path is a zero-length string, contains only white space, or contains one or more invalid characters</exception>
        /// <exception cref="PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
        /// <exception cref="DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="UnauthorizedAccessException">https://docs.microsoft.com/en-us/dotnet/api/system.unauthorizedaccessexception?view=netcore-3.1</exception>
        /// <exception cref="NotSupportedException">Path is in an invalid format.</exception>
        /// <exception cref="SecurityException">The caller does not have the required permission.</exception>
        public void Create(Loan _loan)
        {
            if (_loan == null)
                throw new ArgumentNullException();
            else if (LastIndex == int.MaxValue)
                throw new OverflowException("The loan database is full");
            else
            {
                try
                {
                    LoansDB.Add(LastIndex++, _loan);
                    File.WriteAllText("LoanList.json", JsonSerializer.Serialize(LoansDB));
                }
                catch (SecurityException e)
                {
                    throw new SecurityException("You don't have the enough permission", e);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }

        /// <summary>
        /// Returns the desired loan depending on the given index
        /// </summary>
        /// <param name="_key"></param>
        /// <returns>Loan</returns>
        /// <exception cref="KeyNotFoundException">If the _key doesn't exist in the dictionnary</exception>
        public Loan Read(int _key)
        {
            try
            {
                return LoansDB[_key];
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Updates the old loan with new one by copying state.
        /// </summary>
        /// <param name="_old">Loan</param>
        /// <param name="_new">Loan</param>
        /// <exception cref="ArgumentNullException">If one of the Loan objects given as an argument is null</exception>
        /// <exception cref="ArgumentException">path is a zero-length string, contains only white space, or contains one or more invalid characters</exception>
        /// <exception cref="PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
        /// <exception cref="DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="UnauthorizedAccessException">https://docs.microsoft.com/en-us/dotnet/api/system.unauthorizedaccessexception?view=netcore-3.1</exception>
        /// <exception cref="NotSupportedException">Path is in an invalid format.</exception>
        /// <exception cref="SecurityException">The caller does not have the required permission.</exception>
        public void Update(Loan _old, Loan _new)
        {
            if (_old == null || _new == null)
                throw new ArgumentNullException();
            try
            {
                _old.Copy(_new);
                File.WriteAllText("LoanList.json", JsonSerializer.Serialize(LoansDB));
            }
            catch (SecurityException e)
            {
                throw new SecurityException("You don't have the enough permission", e);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Deletes the loan depending on the input key
        /// </summary>
        /// <param name="_key">int</param>
        /// <exception cref="KeyNotFoundException">If the _key doesn't exist in the dictionnary</exception>
        /// <exception cref="ArgumentNullException">If one of the Loan objects given as an argument is null</exception>
        /// <exception cref="ArgumentException">path is a zero-length string, contains only white space, or contains one or more invalid characters</exception>
        /// <exception cref="PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
        /// <exception cref="DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="UnauthorizedAccessException">https://docs.microsoft.com/en-us/dotnet/api/system.unauthorizedaccessexception?view=netcore-3.1</exception>
        /// <exception cref="NotSupportedException">Path is in an invalid format.</exception>
        /// <exception cref="SecurityException">The caller does not have the required permission.</exception>
        public void Delete(int _key)
        {
            if (!LoansDB.ContainsKey(_key))
                throw new KeyNotFoundException();
            else
            {
                try
                {
                    LoansDB.Remove(_key);
                    File.WriteAllText("LoanList.json", JsonSerializer.Serialize(LoansDB));
                }
                catch (SecurityException e)
                {
                    throw new SecurityException("You don't have the enough permission", e);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        #endregion
    }
}
