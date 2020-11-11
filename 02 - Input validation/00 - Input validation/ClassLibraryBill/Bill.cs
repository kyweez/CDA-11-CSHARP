using ClassLibraryDataCheck;
using System;
using System.Globalization;

namespace ClassLibraryBill
{
    public class Bill
    {
        private string name;
        private DateTime date;
        private double amount;
        private string zipCode;

        public Bill()
        {
            name = "";
            date = DateTime.Now;
            amount = 0;
            zipCode = "00000";
        }

        public Bill(string _name, string _date, string _amount, string _zipcode)
        {
            // NAME
            if (_name == null || !DataCheck.IsValidName(_name))
                name = "";
            else
                name = _name;

            // DATE
            if (_date == null || !DataCheck.IsValidDate(_date))
                date = DateTime.Now;
            else
                date = DateTime.Parse(_date);

            // AMOUNT
            if (_amount == null || !DataCheck.IsValidAmount(_amount))
                amount = 0;
            else
                amount = double.Parse(_amount, CultureInfo.CurrentCulture);

            // ZIPCODE
            if (_zipcode == null || !DataCheck.IsValidZipCode(_zipcode))
                zipCode = "00000";
            else
                zipCode = _zipcode;
        }

        /// <summary>
        ///     This methods overrides the original Tostring method
        ///     Display the current object state
        /// </summary>
        public override string ToString()
        {
            return
                $"Name : {name}\n" +
                $"Date : {date:dd/MM/yyyy}\n" +
                $"Amount : {Math.Round(amount, 2)}\n" +
                $"Zip Code : {zipCode}";
        }
    }
}