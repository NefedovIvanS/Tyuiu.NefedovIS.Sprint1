using Tyuiu.NefedovIS.Sprint1.Task2.V6.Lib;

namespace Tyuiu.NefedovIS.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2456;
            var res = ds.ConvertMToKm(x);
            Assert.AreEqual(2.456, res);
        }
    }
}