using Tyuiu.ShurlyginDS.Sprint2.Task5.V11.Lib;

namespace Tyuiu.ShurlyginDS.Sprint2.Task5.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public string ValidFindDateOfNextDay(int value)
        {
            DataService ds = new DataService();

            Assert.AreEqual("02.05.2023", ds.FindDateOfNextDay(2023, 5, 1));
            Assert.AreEqual("01.09.2023", ds.FindDateOfNextDay(2023, 8, 31));
            Assert.AreEqual("01.03.2023", ds.FindDateOfNextDay(2023, 2, 28));
            Assert.AreEqual("01.01.2024", ds.FindDateOfNextDay(2023, 12, 31));
        }
    }
}
