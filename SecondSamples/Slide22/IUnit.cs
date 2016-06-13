namespace SecondSamples.Slide22
{
    internal interface IUnit
    {
        void Foo();
    }

    internal static class Unit
    {
        public static void Call(IUnit unit)
        {
            unit.Foo();
        }
    }
}