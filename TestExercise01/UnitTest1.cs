using System.Numerics;
using Exercise01;

namespace TestExercise01
{
    [TestClass]
    public class UnitTest1
    {

        //Test 1834
        [TestMethod]
        public void TestCorrectness()
        {
            if (BigInteger.TryParse("1834", out BigInteger bigInteger))
            {
                var inWords = bigInteger.Towards();
                Assert.AreEqual("one thousand eight hundred and thirty four", inWords);
            }
        }

        //Test Auantilion
        [TestMethod]
        public void TestQuantilion()
        {
            if (BigInteger.TryParse("18000000000000000000", out BigInteger bigInteger))
            {
                var inWords = bigInteger.Towards();
                Assert.AreEqual("eighteen quintillion ", inWords);
            }
        }
    }
}