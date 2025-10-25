using Tyuiu.EvdokimovKP.Sprint3.Task5.V8.Lib;

namespace Tyuiu.EvdokimovKP.Sprint3.Task5.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 12;
            double res = ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2);
            double wait = 119.066;
            Assert.AreEqual(res, wait);
        }
    }
}
