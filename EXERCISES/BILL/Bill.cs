using System;
using System.Globalization;
using TOOLS.ClassLibrary;

namespace BILL
{
    public class Bill
    {
        private string name;
        private DateTime date;
        private double amount;
        private string zipCode;

        public Bill(string _name, string _date, string _amount, string _zipcode)
        {
            // NAME
            if (_name == null || !CheckData.IsValidName(_name))
                name = "";
            else
                name = _name;

            // DATE
            if (_date == null || !CheckData.IsValidDate(_date))
                date = DateTime.Now;
            else
                date = DateTime.ParseExact(_date, "dd/MM/yyyy", CultureInfo.CurrentCulture);

            // AMOUNT
            if (_amount == null || !CheckData.IsValidAmount(_amount))
                amount = 0;
            else
                amount = double.Parse(_amount);

            // ZIPCODE
            if (_zipcode == null || !CheckData.IsValidZipCode(_zipcode))
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