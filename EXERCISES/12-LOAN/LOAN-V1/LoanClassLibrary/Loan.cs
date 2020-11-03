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
        #endregion

        #region ********** ATTRIBUTES **********
        private string name;
        private float borrowedCapital;
        private int durationInMonths;
        private float interestRateInPerCent;
        private RepaymentPeriodicity periodicity;
        #endregion

        #region ********** PROPERTIES **********
        public string Name
        {
            get => name;
            set
            {
                if (!Regex.IsMatch(value, REGEX_NAME))
                    throw new BadNameInputFormatException();
                name = value;
            }
        }

        public float BorrowedCapital
        {
            get => borrowedCapital;
            set
            {
                if (value < 0f)
                    throw new InvalidBorrowedCapitalException();
                borrowedCapital = value;
            }
        }

        public int DurationInMonths
        {
            get => durationInMonths;
            set
            {
                if (value < 0)
                    throw new InvalidRepaymentDurationException();
                durationInMonths = value;
            }
        }

        public float InterestRateInPerCent
        {
            get => interestRateInPerCent;
            set
            {
                if (value < 0 || value > 100)
                    throw new InvalidInterestRateException();
                interestRateInPerCent = value;
            }
        }

        public RepaymentPeriodicity Periodicity
        {
            get => periodicity;
            set
            {
                if (!IsValidRepaymentPeriodicity(durationInMonths, value))
                    throw new InvalidRepaymentPeriodicityException();
                periodicity = value;
            }
        }
        #endregion

        #region ********** CONSTRUCTORS **********
        public Loan()
        {
            name = "";
            borrowedCapital = 0f;
            durationInMonths = 1;
            interestRateInPerCent = 7;
            periodicity = RepaymentPeriodicity.Monthly;
        }

        public Loan(string _name, float _borrowedCapital, int _durationInMonths, float _interestRateInPerCent, RepaymentPeriodicity _periodicity)
        {
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