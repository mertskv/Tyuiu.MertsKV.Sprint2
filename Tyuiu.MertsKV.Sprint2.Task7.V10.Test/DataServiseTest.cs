using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint2.Task7.V10.Lib;
namespace Tyuiu.MertsKV.Sprint2.Task7.V10.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataServise ds = new DataServise();
            double x = 1;
            double y = 0;
            
            bool res = ds.CheckDotInShadedArea(x, y);
            
            bool wait = true;
            
            Assert.AreEqual(wait, res);
        }
    
    }
}
