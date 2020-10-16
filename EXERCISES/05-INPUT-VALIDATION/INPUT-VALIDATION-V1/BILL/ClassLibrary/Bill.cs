using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILL.ClassLibrary
{
    class Bill
    {
        private string name;
        private DateTime date;
        private double amount;
        private string zipCode;

        public Bill(string _name, string _date, string _amount, string _zipcode)
        {
            // TODO: Implementer Securite
            name = _name;
            date = DateTime.Parse(_date);
            amount = double.Parse(_amount);
            zipCode = _zipcode;
        }
    }
}
