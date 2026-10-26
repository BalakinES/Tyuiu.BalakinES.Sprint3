using Tyuiu.BalakinES.Sprint3.Task2.V7.Lib;

namespace Tyuiu.BalakinES.Sprint3.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = 82.083;

            Assert.AreEqual(wait, res);

        }
    }
}
