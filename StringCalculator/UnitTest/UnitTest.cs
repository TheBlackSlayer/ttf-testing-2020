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
        public void TestStringheACaso(string str)
        {
            Calculator.Calculate(str);

            Assert.Pass();
        }

        [TestCase("")]
        public void TestStringaVuota(string str)
        {
            Assert.That(Calculator.Calculate(str), Is.EqualTo(0));
        }

        [TestCase("18", 18)]
        [TestCase("7435", 7435)]
        [TestCase("789", 789)]
        public void TestStringheNumeriche(string str, int num)
        {
            Assert.That(Calculator.Calculate(str), Is.EqualTo(num));
        }
    }
}