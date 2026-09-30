using Tyuiu.MotorinDA.Sprint1.Task4.V0.Lib;
namespace Tyuiu.MotorinDA.Sprint1.Task4.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-0.0024787490329332366, res);
        }
    }
}
