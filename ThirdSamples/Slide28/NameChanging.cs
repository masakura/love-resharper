namespace ThirdSamples.Slide28
{
    internal class NameChanging
    {
        private readonly string _name;

        public NameChanging(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}