using NUnit.Framework;
using StringCalculator;


namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("gdsg")]
        [TestCase("4wf4")]
        [TestCase("18")]
        public void TestStringheNormali(string str)
        {
            Calculator.Calculate(str);

            Assert.Pass();
        }
    }
}