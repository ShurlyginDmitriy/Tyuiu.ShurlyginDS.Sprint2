using Tyuiu.ShurlyginDS.Sprint2.Task6.V1.Lib;

namespace Tyuiu.ShurlyginDS.Sprint2.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual(31, ds.FindMonthDaysCount(1));
            Assert.AreEqual(31, ds.FindMonthDaysCount(3));
            Assert.AreEqual(31, ds.FindMonthDaysCount(12));

            
            Assert.AreEqual(30, ds.FindMonthDaysCount(4));
            Assert.AreEqual(30, ds.FindMonthDaysCount(11));


            Assert.AreEqual(28, ds.FindMonthDaysCount(2));
        }
    }
}
