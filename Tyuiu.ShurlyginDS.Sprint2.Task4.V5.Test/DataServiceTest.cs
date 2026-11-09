using Tyuiu.ShurlyginDS.Sprint2.Task4.V5.Lib;

namespace Tyuiu.ShurlyginDS.Sprint2.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 0.5926;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 6;

            double res = ds.Calculate(x, y);
            double wait = 200.17;
            Assert.AreEqual(wait, res);
        }
    }
}
