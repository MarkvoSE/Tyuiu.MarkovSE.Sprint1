using Tyuiu.MarkovSE.Sprint1.Task3.V15.Lib;
namespace Tyuiu.MarkovSE.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double v1 = 100;
            double v2 = 150;
            double S = 300;
            double T= 1;
            double wait = 50;
            var res = ds.DistanceOverTime( v1,  v2,  S,  T);
            Assert.AreEqual(res, wait);
        }
    }
}