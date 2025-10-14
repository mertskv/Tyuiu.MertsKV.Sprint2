using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint2.Task3.V7.Lib;

namespace Tyuiu.MertsKV.Sprint2.Task3.V7.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataServise ds = new DataServise();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 50;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataServise ds = new DataServise();
            double x = 0;
            double wait = 0.75;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataServise ds = new DataServise();
            double x = -1;
            double wait = 0.125;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataServise ds = new DataServise();
            double x = -12;
            double wait = 20736.25;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }


    }
}
