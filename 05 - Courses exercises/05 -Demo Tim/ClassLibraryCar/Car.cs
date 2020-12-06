namespace ClassLibraryCar
{
    public class Car
    {
        #region ############### PROPERTIES ###############
        public string Brand
        {
            get;
            protected set;
        }

        public string Model
        {
            get;
            protected set;
        }

        public int WeightInKg
        {
            get;
            protected set;
        }

        public Motor CurrentMotor
        {
            get;
            protected set;
        }

        #endregion

        #region ############### CONSTRUCTOR ###############
        public Car(string _brand, string _model, int _weightInKg, Motor _currentMotor)
        {
            //Brand
            if (_brand == null)
                Brand = "undefined";
            else
                Brand = _brand;

            //Model
            if (_model == null)
                Model = "undefined";
            else
                Model = _model;

            //Weight
            if (_weightInKg < 0)
                WeightInKg = 0;
            else
                WeightInKg = _weightInKg;

            //Motor
            if (_currentMotor == null)
                CurrentMotor = new Motor("undefined", 0);
            else
                CurrentMotor = _currentMotor;
        }

        public Car(string _brand, string _model, Motor _currentMotor) : this(_brand, _model, 1000, _currentMotor)
        {
        }
        #endregion

        #region ############### METHODS ###############

        public string GetInfo()
        {
            return $"Brand : {Brand}\nModel : {Model}\nWeight in kg : {WeightInKg}";
        }

        public float CalculateMaxSpeed()
        {
            return this.CurrentMotor.MaxSpeedInKmPerHour - (this.WeightInKg * 0.3f);
        }
        #endregion
    }
}