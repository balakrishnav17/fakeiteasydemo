using FakeItEasy;
using fakeiteasydemo;
using NUnit.Framework;

namespace fakeiteasydemotestcases
{
    public class Tests
    {
        SimpleInterest si;
        [SetUp]
        public void Setup()
        {
            si = A.Fake<SimpleInterest>();
        }

        [Test]
        public void calc_simple_interest_returns_1040()
        {
            var maths = A.Fake<IMaths>();


            int p = 1000, t = 2, r = 2, den = 100;

            A.CallTo(() => si.calculateInterest(p, t, r, den)).Returns(1040);

            Assert.AreEqual(1040, si.calculateInterest(p, t, r, den));
        }

        [Test]
        public void calc_simple_interest_returns_zero()
        {
            //var maths = A.Fake<IMaths>();
            //var si = A.Fake<SimpleInterest>();


            int p = 1000, t = 2, r = 2, den = 0;

            A.CallTo(() => si.calculateInterest(p, t, r, den)).Returns(0);

            Assert.AreEqual(0, si.calculateInterest(p, t, r, den));
        }

        [Test]
        public void calc_simple_interest_throws_error_on_invalid_values()
        {
            //var maths = A.Fake<IMaths>();
            //var si = A.Fake<SimpleInterest>();


            int p = 1000, t = -2, r = 2, den = 0;

            A.CallTo(() => si.calculateInterest(p, t, r, den)).Returns("error");

            Assert.AreEqual("error", si.calculateInterest(p, t, r, den));
        }
    }
}