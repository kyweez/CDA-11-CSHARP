﻿using PersonClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClientListClassLibrary
{
    [Serializable]
    public class ClientList
    {
        private const string databaseFile = "./ClientList.json";

        #region PROPERTIES
        public Dictionary<int, Person> ClientsDB
        {
            get; private set;
        }
        public int LastIndex
        {
            get; private set;
        }
        #endregion

        #region CONSTRUCTORS
        public ClientList()
        {
            if (File.Exists(databaseFile))
            {
                ClientsDB = JsonSerializer.Deserialize<Dictionary<int, Person>>(File.ReadAllText(databaseFile));
                LastIndex = ClientsDB.Keys.Last();
            }
            else
            {
                ClientsDB = new Dictionary<int, Person>();
                LastIndex = 0;
            }

        }
        #endregion

        #region METHODS
        /// <summary>
        /// Creates a new entry in the database
        /// </summary>
        /// <param name="_client">Person</param>
        /// <exception cref="ArgumentNullException">If the Person object given as an argument is null</exception>
        /// <exception cref="OverflowException">The client database is full</exception>
        /// <exception cref="ArgumentException">path is a zero-length string, contains only white space, or contains one or more invalid characters</exception>
        /// <exception cref="PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
        /// <exception cref="DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="UnauthorizedAccessException">https://docs.microsoft.com/en-us/dotnet/api/system.unauthorizedaccessexception?view=netcore-3.1</exception>
        /// <exception cref="NotSupportedException">Path is in an invalid format.</exception>
        /// <exception cref="SecurityException">The caller does not have the required permission.</exception>
        public void Create(Person _client)
        {
            if (_client == null)
                throw new ArgumentNullException();
            else if (LastIndex == int.MaxValue)
                throw new OverflowException("The client database is full");
            else
            {
                try
                {
                    ClientsDB.Add(LastIndex++, _client);
                    File.WriteAllText("ClientList.json", JsonSerializer.Serialize(ClientsDB));
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
        /// Returns the desired client depending on the given index
        /// </summary>
        /// <param name="_key"></param>
        /// <returns>Person</returns>
        /// <exception cref="KeyNotFoundException">If the _key doesn't exist in the dictionnary</exception>
        public Person Read(int _key)
        {
            try
            {
                return ClientsDB[_key];
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
        /// Updates the old client with new one by copying state.
        /// </summary>
        /// <param name="_old">Person</param>
        /// <param name="_new">Person</param>
        /// <exception cref="ArgumentNullException">If one of the Person objects given as an argument is null</exception>
        /// <exception cref="ArgumentException">path is a zero-length string, contains only white space, or contains one or more invalid characters</exception>
        /// <exception cref="PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
        /// <exception cref="DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="UnauthorizedAccessException">https://docs.microsoft.com/en-us/dotnet/api/system.unauthorizedaccessexception?view=netcore-3.1</exception>
        /// <exception cref="NotSupportedException">Path is in an invalid format.</exception>
        /// <exception cref="SecurityException">The caller does not have the required permission.</exception>
        public void Update(Person _old, Person _new)
        {
            if (_old == null || _new == null)
                throw new ArgumentNullException();
            try
            {
                _old.Copy(_new);
                File.WriteAllText("ClientList.json", JsonSerializer.Serialize(ClientsDB));
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
        /// Deletes the client depending on the input key
        /// </summary>
        /// <param name="_key">int</param>
        /// <exception cref="KeyNotFoundException">If the _key doesn't exist in the dictionnary</exception>
        /// <exception cref="ArgumentNullException">If one of the Person objects given as an argument is null</exception>
        /// <exception cref="ArgumentException">path is a zero-length string, contains only white space, or contains one or more invalid characters</exception>
        /// <exception cref="PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length.</exception>
        /// <exception cref="DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive).</exception>
        /// <exception cref="IOException">An I/O error occurred while opening the file.</exception>
        /// <exception cref="UnauthorizedAccessException">https://docs.microsoft.com/en-us/dotnet/api/system.unauthorizedaccessexception?view=netcore-3.1</exception>
        /// <exception cref="NotSupportedException">Path is in an invalid format.</exception>
        /// <exception cref="SecurityException">The caller does not have the required permission.</exception>
        public void Delete(int _key)
        {
            if (!ClientsDB.ContainsKey(_key))
                throw new KeyNotFoundException();
            else
            {
                try
                {
                    ClientsDB.Remove(_key);
                    File.WriteAllText("ClientList.json", JsonSerializer.Serialize(ClientsDB));
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