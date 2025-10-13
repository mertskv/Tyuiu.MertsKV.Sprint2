using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint2.Task0.V19.Lib;

namespace Tyuiu.MertsKV.Sprint2.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataServise ds = new DataServise();
            int x = 105;
            int y = 177;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, true, true, true, true, true, };

            CollectionAssert.AreEqual(wait, res);


        }
    }
}
