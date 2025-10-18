using Tyuiu.EvdokimovKP.Sprint3.Task2.V12.Lib;

namespace Tyuiu.EvdokimovKP.Sprint3.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 5;
            int value = 5;
            double res = ds.GetMultiplySeries(startValue, stopValue, value);
            double wait = 305;
            Assert.AreEqual(wait, res);
        }
    }
}
