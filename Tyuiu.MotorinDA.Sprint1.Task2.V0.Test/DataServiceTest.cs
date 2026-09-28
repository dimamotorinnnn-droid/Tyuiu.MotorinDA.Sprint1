using Tyuiu.MotorinDA.Sprint1.Task2.V0.Lib;
namespace Tyuiu.MotorinDA.Sprint1.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 20;
            var res = ds.CalculateMinutesSinceStart(x, y);
            Assert.AreEqual(80, res);
        }
    }
}
