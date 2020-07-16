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

        //[TestCase("gdsg")]
        //[TestCase("4wf4")]
        //[TestCase("18")]
        //public void TestStringheACaso(string str)
        //{
        //    Calculator.Add(str);

        //    Assert.Pass();
        //}

        [TestCase("")]
        public void TestStringaVuota(string str)
        {
            Assert.That(Calculator.Add(str), Is.EqualTo(0));
        }

        [TestCase("18", 18)]
        [TestCase("7435", 7435)]
        [TestCase("789", 789)]
        public void TestStringheNumeriche(string str, int num)
        {
            Assert.That(Calculator.Add(str), Is.EqualTo(num));
        }

        [TestCase("18,2", 20)]
        [TestCase("74,3", 77)]
        [TestCase("7,74", 81)]
        public void TestStringheConSomma(string str, int num)
        {
            Assert.That(Calculator.Add(str), Is.EqualTo(num));
        }

        [TestCase("8,2,10", 20)]
        [TestCase("74,3,3", 80)]
        [TestCase("3,3,3,3,3,3", 18)]
        public void TestStringheConSommaDiPiuNumeri(string str, int num)
        {
            Assert.That(Calculator.Add(str), Is.EqualTo(num));
        }

        [TestCase("8\n2,10", 20)]
        [TestCase("74\n3\n3", 80)]
        [TestCase("3,3\n3,3,3\n3", 18)]
        public void TestStringheConSommaDiPiuNumeriEBackslashn(string str, int num)
        {
            Assert.That(Calculator.Add(str), Is.EqualTo(num));
        }
    }
}