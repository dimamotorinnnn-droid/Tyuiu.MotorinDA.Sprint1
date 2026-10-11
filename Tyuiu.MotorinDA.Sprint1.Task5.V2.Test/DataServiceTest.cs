using Tyuiu.MotorinDA.Sprint1.Task5.V2.Lib;
namespace Tyuiu.MotorinDA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double temp = 77;
            double res = ds.FahrenheitToСelsius(temp);
            int result = Convert.ToInt32(res);
            Assert.AreEqual(25, result);
        }
    }
}
