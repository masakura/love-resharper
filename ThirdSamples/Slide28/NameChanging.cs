namespace ThirdSamples.Slide28
{
    internal class NameChanging
    {
        private readonly string _nmea;

        public NameChanging(string nmea)
        {
            _nmea = nmea;
        }

        public string Nmea
        {
            get { return _nmea; }
        }
    }
}