using Tyuiu.MarkovSE.Sprint1.Task7.V15.Lib;
namespace Tyuiu.MarkovSE.Sprint1.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = 0.539;
            Assert.AreEqual(res, ds.Calculate(x));
        }
    }
}