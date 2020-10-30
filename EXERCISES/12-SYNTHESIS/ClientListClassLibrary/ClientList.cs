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
        /// Create a new entry in the database
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
            }
            catch (Exception e)
            {
                throw e;
            }
            Serialization = JsonSerializer.Serialize(ClientsDB);
        }
        #endregion
    }
}
