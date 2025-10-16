using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint2.Task6.V7.Lib;
namespace Tyuiu.MertsKV.Sprint2.Task6.V7.Test
{
    [TestClass]
    public  class DataServiseTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataServise ds = new DataServise();
            int n = 5;
            int startYear = 1990;
            string res = ds.FindMonthName(startYear, n);
            string wait = "июнь";
            Assert.AreEqual(wait, res);
        }
    }
}
