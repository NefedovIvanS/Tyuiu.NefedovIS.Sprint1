using Tyuiu.NefedovIS.Sprint1.Task6.V14.Lib;

namespace Tyuiu.NefedovIS.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            char[] russianLetters = new char[32];
            for (int i = 0; i < 32; i++)
            {
                russianLetters[i] = (char)('а' + i);
            }
            string strTest = "я с перми купаюсь в каме";
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckLowerCaseRusLetters(strTest));
        }
    }
}