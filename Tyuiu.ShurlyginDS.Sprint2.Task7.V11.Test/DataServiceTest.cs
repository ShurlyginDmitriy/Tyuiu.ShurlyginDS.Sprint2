using Tyuiu.ShurlyginDS.Sprint2.Task7.V11.Lib;

namespace Tyuiu.ShurlyginDS.Sprint2.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = -0.5;
            double y = 0.5;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;
            Assert.AreEqual(wait, res);

            x = 0.5;
            y = 0.2;

            res = ds.CheckDotInShadedArea(x, y);

            wait = true;

            Assert.AreEqual(wait, res);

            x = 1;
            y = 1;

            res = ds.CheckDotInShadedArea(x, y);

            wait = false;
            Assert.AreEqual(wait, res);

        }
    }
}
