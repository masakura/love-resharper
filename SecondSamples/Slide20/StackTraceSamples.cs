using System;
using NUnit.Framework;

namespace SecondSamples.Slide20
{
    [TestFixture]
    internal sealed class StackTraceSamples
    {
        public void A()
        {
            B();
            C();
        }

        private void B()
        {
            C();
        }

        private void C()
        {
            throw new Exception();
        }

        [Test]
        public void TestMethod()
        {
            A();
        }
    }
}