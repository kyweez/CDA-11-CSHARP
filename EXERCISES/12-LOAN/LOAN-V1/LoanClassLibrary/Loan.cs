using LoanClassLibrary.LoanExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LoanClassLibrary
{
    public class Loan
    {
        #region ********** CONSTANTS **********
        private const string REGEX_NAME = @"^[a-zA-Z]+([\-\' ][a-zA-Z]+)*$";
        private int durationInMonths;
        #endregion

        #region ********** ATTRIBUTES **********
        private string name;
        private float borrowedCapital;
        private int durationInMonths;

        #region ********** PROPERTIES **********
        public string Name
        {
            get; private set;
        }
        public float BorrowedCapital
        {
            get; private set;
        }

        public int DurationInMonths
        {
            get; private set;
        }

        public float InterestRateInPerCent
        {
            get; private set;
        }

        public RepaymentPeriodicity Periodicity
        {
            get; private set;
        }
        #endregion

        #region ********** CONSTRUCTORS **********
        public Loan()
        {
            Name = "";
            BorrowedCapital = 0f;
            DurationInMonths = 1;
            InterestRateInPerCent = 7;
            Periodicity = RepaymentPeriodicity.Monthly;
        }

        public Loan(string _name, float _borrowedCapital, int _durationInMonths, float _interestRateInPerCent, RepaymentPeriodicity _periodicity)
        {
            if (!Regex.IsMatch(_name, REGEX_NAME))
                throw new BadNameInputFormatException();
            if (_borrowedCapital < 0f)
                throw new InvalidBorrowedCapitalException();
            if (_durationInMonths < 0)
                throw new InvalidRepaymentDurationException();
            if (_interestRateInPerCent < 0 || _interestRateInPerCent > 100)
                throw new InvalidInterestRateException();
            if (!IsValidRepaymentPeriodicity(_durationInMonths, _periodicity))
                throw new InvalidRepaymentPeriodicityException();
            Name = _name;
            BorrowedCapital = _borrowedCapital;
            DurationInMonths = _durationInMonths;
            InterestRateInPerCent = _interestRateInPerCent;
            Periodicity = _periodicity;
        }

        public Loan(Loan _loan)
        {
            Name = _loan.Name;
            BorrowedCapital = _loan.BorrowedCapital;
            DurationInMonths = _loan.DurationInMonths;
            InterestRateInPerCent = _loan.InterestRateInPerCent;
            Periodicity = _loan.Periodicity;
        }
        #endregion

        #region ********** METHODS **********

        public int GetRepaymentNumber()
        {
            return (DurationInMonths / Convert.ToInt32(Periodicity));
        }

        /// <summary>
        /// This mehtod checks if the given periodicity fits with the given duration months
        /// </summary>
        /// <param name="_durationInMonths">int</param>
        /// <param name="_periodicity">RepaymentPeriodicity</param>
        /// <returns>bool</returns>
        /// <exception cref="InvalidRepaymentDurationException">The input date of birth is not valid</exception>
        public bool IsValidRepaymentPeriodicity(int _durationInMonths, RepaymentPeriodicity _periodicity)
        {
            if (_durationInMonths < 0)
                throw new InvalidRepaymentDurationException();
            if (_durationInMonths % Convert.ToInt32(_periodicity) != 0)
                return false;
            return true;
        }
        #endregion
    }
}