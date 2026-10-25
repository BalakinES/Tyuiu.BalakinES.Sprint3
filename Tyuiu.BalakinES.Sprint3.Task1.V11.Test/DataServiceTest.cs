using Tyuiu.BalakinES.Sprint3.Task1.V11.Lib;

namespace Tyuiu.BalakinES.Sprint3.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultCheck()
        {
            DataService ds = new DataService();

            double value = 0.75;
            int startValue = 1;
            int stopValue = 14;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 0.005;

            Assert.AreEqual(wait, res);
        }
    }
}
