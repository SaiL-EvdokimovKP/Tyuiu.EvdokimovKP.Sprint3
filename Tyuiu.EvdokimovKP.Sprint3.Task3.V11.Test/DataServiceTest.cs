using Tyuiu.EvdokimovKP.Sprint3.Task3.V11.Lib;

namespace Tyuiu.EvdokimovKP.Sprint3.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "sqwreq vqwqq q";
            char replaceable = '7';
            char replacement = 'q';
            string res = ds.ReplaceCharOnNum(value, replaceable, replacement);
            string wait = "s7wre7 v7w77 7";
            Assert.AreEqual(res, wait);
        }
    }
}
