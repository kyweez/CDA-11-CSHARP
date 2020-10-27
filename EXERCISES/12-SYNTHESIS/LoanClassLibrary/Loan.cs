using LoanClassLibrary.LoanExceptions;
using PersonClassLibrary;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LoanClassLibrary
{
    public class Loan
    {
        #region Constants
        private const int MIN_BORROWED_CAPITAL = 1000;
        private const int MAX_BORROWED_CAPITAL = 1000000;
        private const int MIN_DURATION_IN_MONTHS = 1;
        private const int MAX_DURATION_IN_MONTHS = 300;

        #endregion

        #region Attributes
        private Person client;
        private int borrowedCapital;
        private int durationInMonths;
        private int interestRate;
        private RepaymentPeriodicity periodicity;
        #endregion

        #region Constructors
        public Loan(Person _client, int _borrowedCapital, int _durationInMonths, int _interestRate, RepaymentPeriodicity _periodicity)
        {
            if (_client == null)
                throw new ArgumentNullException();
            if (_borrowedCapital < MIN_BORROWED_CAPITAL || _borrowedCapital > MAX_BORROWED_CAPITAL)
                throw new InvalidBorrowedCapitalException();
            if (_durationInMonths < MIN_DURATION_IN_MONTHS || _durationInMonths > MAX_DURATION_IN_MONTHS)
                throw new InvalidRepaymentDurationException();
            if (_interestRate < 7 || _interestRate > 9)
                throw new InvalidInterestRateException();

        }
        #endregion

        //
        // Exceptions:
        //   T:System.FormatException:
        //     value is not in an appropriate format.
        //
        //   T:System.InvalidCastException:
        //     value does not implement the System.IConvertible interface. -or-The conversion
        //     is not supported.
        //
        //   T:System.OverflowException:
        //     value represents a number that is less than System.Int32.MinValue or greater
        //     than System.Int32.MaxValue.


        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_durationInMonths"></param>
        /// <param name="_periodicity"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Input or pattern is null</exception>
        /// <exception cref="RegexMatchTimeoutException">A time-out occurred</exception>
        /// <exception cref="BadNameInputFormatException">Input names don't fit to the given regex</exception>
        /// <exception cref="BadDateStringFormatException">The input string doesn't have a good format</exception>
        /// <exception cref="InvalidDateOfBirthException">The input date of birth is not valid</exception>
        private bool IsValidRepaymentPeriodicity(int _durationInMonths, RepaymentPeriodicity _periodicity)
        {
            try
            {
                if (_durationInMonths < MIN_DURATION_IN_MONTHS || _durationInMonths > MAX_DURATION_IN_MONTHS)
                    throw new InvalidRepaymentDurationException();
                if (_durationInMonths % Convert.ToInt32(_periodicity) != 0)
                    return false;
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion
    }
}