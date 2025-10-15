using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint2.Task4.V29.Lib;
namespace Tyuiu.MertsKV.Sprint2.Task4.V29.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataServise ds = new DataServise();
            double x = 3;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 8.6;
            Assert.AreEqual(wait, res);
        }
        
        
    }
}
