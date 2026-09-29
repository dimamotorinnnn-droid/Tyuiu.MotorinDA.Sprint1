using Tyuiu.MotorinDA.Sprint1.Task3.V0.Lib;
namespace Tyuiu.MotorinDA.Sprint1.Task3.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 2;
            double h = 3;
            
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(37.68, res);
        }
    }
}
