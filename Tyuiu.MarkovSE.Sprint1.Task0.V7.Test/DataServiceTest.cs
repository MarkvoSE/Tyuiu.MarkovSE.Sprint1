using Tyuiu.MarkovSE.Sprint1.Task0.V7.Lib;
namespace Tyuiu.MarkovSE.Sprint1.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(5, res);
        }
    }
}