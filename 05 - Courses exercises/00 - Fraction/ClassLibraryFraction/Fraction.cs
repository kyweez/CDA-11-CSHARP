using ClassLibraryFraction.Exceptions;
using System;

namespace ClassLibraryFraction
{
    public class Fraction
    {
        #region ################ PROPERTIES ################
        private int Numerator
        {
            get;
            set;
        }
        
        private int Denominator
        {
            get;
            set;
        }
        #endregion

        #region ################ CONSTRUCTORS ################
        /// <summary>
        /// Instantiate a fraction
        /// </summary>
        /// <param name="_numerator">int</param>
        /// <param name="_denominator">int</param>
        /// <exception cref="ZeroDenominatorException">Triggers if the denominator is equal to 0</exception>
        public Fraction(int _numerator, int _denominator)
        {
            if (_denominator == 0)
                throw new ZeroDenominatorException("Denominator can't be equal to 0");
            Numerator = _numerator;
            Denominator = _denominator;
        }

        /// <summary>
        /// Instantiate a fraction
        /// </summary>
        /// <param name="_numerator">int</param>
        public Fraction(int _numerator) : this(_numerator, 1)
        {
        }
        #endregion

        #region ################ METHODS ################
        /// <summary>
        /// Reverse the current fraction
        /// </summary>
        /// <exception cref="FractionReverseImpossibleException">Triggers if the numerator is equal to 0</exception>
        public void Reverse()
        {
            if (Numerator == 0)
                throw new FractionReverseImpossibleException("Can't reverse a fraction with numerator equal to 0");
            int tmp = Numerator;
            Numerator = Denominator;
            Denominator = tmp;
        }

        /// <summary>
        /// Gives an evaluation of the fraction
        /// </summary>
        /// <returns></returns>
        /// <exception cref="FractionEvaluationImpossibleException">Triggers if the fraction has a denominator equal to 0</exception>

        public double Evaluate()
        {
            int result;
            try
            {
                result = Numerator / Denominator;
                return result;
            }
            catch (DivideByZeroException e)
            {
                throw new FractionEvaluationImpossibleException("Denominator is equal to 0", e);
            }
        }
        #endregion
    }
}