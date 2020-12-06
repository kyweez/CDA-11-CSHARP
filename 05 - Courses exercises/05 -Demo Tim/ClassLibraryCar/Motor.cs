namespace ClassLibraryCar
{
    public class Motor
    {
        #region ############### PROPERTIES ###############
        public string Brand
        {
            get;
            protected set;
        }

        public int MaxSpeedInKmPerHour
        {
            get;
            protected set;
        }

        #endregion

        #region ############### CONSTRUCTOR ###############
        public Motor(string _brand, int _maxSpeedInKmPerHour)
        {
            // Brand
            if (_brand == null)
                Brand = "undefined";
            else
                Brand = _brand;

            // Max speed
            if (_maxSpeedInKmPerHour < 0)
                MaxSpeedInKmPerHour = 0;
            else
                MaxSpeedInKmPerHour = _maxSpeedInKmPerHour;
        }
        #endregion
    }
}