using PersonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClientListClassLibrary
{
    [Serializable]
    public class ClientList
    {
        #region PROPERTIES
        private Dictionary<int, Person> ClientsDB
        {
            get; set;
        }
        private string Serialization
        {
            get; set;
        }
        private int LastIndex
        {
            get; set;
        }
        #endregion

        #region CONSTRUCTORS
        public ClientList()
        {
            ClientsDB = new Dictionary<int, Person>();
            Serialization = "";
            LastIndex = 0;
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Creates a new entry in the database
        /// </summary>
        /// <param name="_client">Person</param>
        /// <exception cref="ArgumentNullException">If the Person object given as an argument is null</exception>
        public void Create(Person _client)
        {
            if (_client == null)
                throw new ArgumentNullException();
            try
            {
                ClientsDB.Add(LastIndex++, _client);
                Serialization = JsonSerializer.Serialize(ClientsDB);
            }
            catch (Exception e)
            {
                throw e;
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
        public void Update(Person _old, Person _new)
        {
            if (_old == null || _new == null)
                throw new ArgumentNullException();
            try
            {
                _old.Copy(_new);
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
        public void Delete(int _key)
        {
            if (!ClientsDB.ContainsKey(_key))
                throw new KeyNotFoundException();
            ClientsDB.Remove(_key);
        }
        #endregion
    }
}
