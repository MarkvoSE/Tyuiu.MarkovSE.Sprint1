using Tyuiu.MarkovSE.Sprint1.Task2.V1.Lib;
namespace Tyuiu.MarkovSE.Sprint1.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertKmToM(x);
            Assert.AreEqual(3,218, res);
        }
    }
}