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
        [TestCase(1400, false)]
        [TestCase(500, false)]
        [TestCase()]
        public void Test(int anno, bool bisestile)
        {
            Assert.That(Year.Calculate(anno), Is.EqualTo(bisestile));
        }
    }
}