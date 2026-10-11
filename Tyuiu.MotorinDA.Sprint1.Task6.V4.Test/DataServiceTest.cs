using Tyuiu.MotorinDA.Sprint1.Task6.V4.Lib;
namespace Tyuiu.MotorinDA.Sprint1.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "правда нравственный культура";
            DataService ds = new DataService();
            string res = ds.CheckDoubleN(strTest);
            string wait = "нравственный";
            Assert.AreEqual(wait, res);
        }
    }
}
