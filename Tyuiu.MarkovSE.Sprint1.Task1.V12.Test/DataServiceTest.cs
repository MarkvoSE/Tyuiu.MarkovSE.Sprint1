using Tyuiu.MarkovSE.Sprint1.Task1.V12.Lib;
namespace Tyuiu.MarkovSE.Sprint1.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(0,5,res);
        }
    }
}