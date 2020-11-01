using ClientListClassLibrary;
using LoanListClassLibrary;
using PersonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisApp
{
    public class LoanApp
    {
        private ClientList Clients
        {
            get; set;
        }
        private LoanList Loans
        {
            get; set;
        }
        private Dictionary<Person, Loan> LoanAppList
        {
            get; set;
        }
        public LoanApp()
        {
            Clients = new ClientList();
            Loans = new LoanList();
            LoanAppList = new Dictionary<Person, Loan>();
            foreach (int key in Clients.ClientsDB.Keys)
            {
                LoanAppList.Add(Clients.Read(key), tamer);
            }
        }
    }
}
