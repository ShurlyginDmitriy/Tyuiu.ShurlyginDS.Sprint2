using Tyuiu.ShurlyginDS.Sprint2.Task3.V12.Lib;

namespace Tyuiu.ShurlyginDS.Sprint2.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 10;
            Assert.AreEqual(wait, res);
        }

        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1.5403;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 12;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -17;
            double res = ds.Calculate(x);
            double wait = -186.941;
            Assert.AreEqual(wait, res);
        }
    }
}
