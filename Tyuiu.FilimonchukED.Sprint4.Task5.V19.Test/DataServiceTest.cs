using Tyuiu.FilimonchukED.Sprint4.Task5.V19.Lib;
namespace Tyuiu.FilimonchukED.Sprint4.Task5.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mtrx = { { -2, 1, 2 }, { -1, 2, 3 }, { -2, 3, -2 }, };
            int res = ds.Calculate(mtrx);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
