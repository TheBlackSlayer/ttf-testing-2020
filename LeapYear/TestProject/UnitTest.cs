using LeapYear;
using NUnit.Framework;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2012, true)]
        [TestCase(2032, true)]
        [TestCase(1783, false)]
        [TestCase(1400, true)]
        [TestCase(500, true)]
        [TestCase(400, true)]
        [TestCase(2000, true)]
        [TestCase(1100, true)]
        [TestCase(800, true)]
        [TestCase(300, true)]
        [TestCase(-20, false)]
        [TestCase(-3, false)]
        [TestCase(-1865, false)]
        public void Test(int anno, bool bisestile)
        {
            Assert.That(Year.Calculate(anno), Is.EqualTo(bisestile));
        }
    }
}