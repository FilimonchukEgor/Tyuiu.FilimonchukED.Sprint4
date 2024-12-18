using Tyuiu.FilimonchukED.Sprint4.Task6.V2.Lib;
namespace Tyuiu.FilimonchukED.Sprint4.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] mas = { "asd", "asdasd", "asdasdasd", "asdd" };
            string[] res = ds.Calculate(mas);
            string[] wait = { "asdasd", "asdasdasd" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
