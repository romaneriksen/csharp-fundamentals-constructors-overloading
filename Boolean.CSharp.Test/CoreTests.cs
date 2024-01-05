using Boolean.CSharp.Main;
using NUnit.Framework;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
     

        [Test]
        public void TestQuestion1()
        {
            Core core = new Core();
            Assert.IsTrue(core.Question1().Make!=string.Empty);
            Assert.IsTrue(core.Question1().Model != string.Empty);
        }
        [Test]
        public void TestQuestion2()
        {
            Core core = new Core();
            Assert.IsTrue(core.Question2());

        }
        [Test]
        public void TestQuestion3()
        {
            Core core = new Core();

            Assert.IsTrue(core.Question3().WheelCount>0);

        }
        [Test]
        public void TestQuestion4()
        {
            Core core = new Core();
            Assert.IsTrue(core.Question4().NameOfUnicyclist.Length>0);

        }
        [Test]
        public void TestQuestion5()
        {
            Core core = new Core();
            Assert.IsTrue(core.Question5().IsFlightCancelled);
            Assert.IsTrue(core.Question5().FlightDetails() != "##LHR##JFK##");
        }
    }
}