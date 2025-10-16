using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint2.Task7.V10.Lib;
namespace Tyuiu.MertsKV.Sprint2.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataServise ds = new DataServise();
            double x = 0.7;
            double y = 0.5;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    
    }
}
