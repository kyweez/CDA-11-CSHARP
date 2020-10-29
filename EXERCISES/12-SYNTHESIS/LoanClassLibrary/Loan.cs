using LoanClassLibrary.LoanExceptions;
using PersonClassLibrary;
using System;

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

        /// <summary>
        /// Loan constructor
        /// </summary>
        /// <param name="_client">Person</param>
        /// <param name="_borrowedCapital">int</param>
        /// <param name="_durationInMonths">int</param>
        /// <param name="_interestRate">int</param>
        /// <param name="_periodicity">RepaymentPeriodicity</param>
        /// <exception cref="ArgumentNullException">Input or pattern is null</exception>
        /// <exception cref="InvalidBorrowedCapitalException">Invalid borrowed capital input</exception>
        /// <exception cref="InvalidRepaymentDurationException">Invalid repayment duration input</exception>
        /// <exception cref="InvalidInterestRateException">Invalid rate interest input</exception>
        /// <exception cref="InvalidRepaymentPeriodicityException">Invalid repayment periodicity input</exception>
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
            if (!IsValidRepaymentPeriodicity(_durationInMonths, _periodicity))
                throw new InvalidRepaymentPeriodicityException();
            client = _client;
            borrowedCapital = _borrowedCapital;
            durationInMonths = _durationInMonths;
            interestRate = _interestRate;
            periodicity = _periodicity;
        }
        #endregion

        #region Methods

        /// <summary>
        /// This mehtod checks if the given periodicity fits with the given duration months
        /// </summary>
        /// <param name="_durationInMonths">int</param>
        /// <param name="_periodicity">RepaymentPeriodicity</param>
        /// <returns>bool</returns>
        /// <exception cref="InvalidRepaymentDurationException">The input date of birth is not valid</exception>
        private bool IsValidRepaymentPeriodicity(int _durationInMonths, RepaymentPeriodicity _periodicity)
        {
            if (_durationInMonths < MIN_DURATION_IN_MONTHS || _durationInMonths > MAX_DURATION_IN_MONTHS)
                throw new InvalidRepaymentDurationException();
            if (_durationInMonths % Convert.ToInt32(_periodicity) != 0)
                return false;
            return true;
        }
        #endregion
    }
}