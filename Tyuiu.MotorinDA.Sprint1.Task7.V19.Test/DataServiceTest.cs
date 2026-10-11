using Tyuiu.MotorinDA.Sprint1.Task7.V19.Lib;
namespace Tyuiu.MotorinDA.Sprint1.Task7.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService(); 
            double x = 1;
            var res = ds.Calculate(x);
            var wait = -5.159;
            Assert.AreEqual(wait, res);
        }
    }
}
