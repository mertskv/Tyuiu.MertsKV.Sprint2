using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint2.Task5.V2.Lib;
namespace Tyuiu.MertsKV.Sprint2.Task5.V2.Test
{
    [TestClass]
    public  class DataServiseTest
    {
        [TestMethod]
        public void TestWinterMonth()
        {
            DataServise ds = new DataServise();
            string result = ds.FindMonthSeason(1);
            Assert.AreEqual("Зима", result);
        }

        [TestMethod]
        public void TestSummerMonth()
        {
            DataServise ds = new DataServise();
            string result = ds.FindMonthSeason(7);
            Assert.AreEqual("Лето", result);
        }

        [TestMethod]
        public void TestInvalidMonth()
        {
            DataServise ds = new DataServise();
            string result = ds.FindMonthSeason(13);
            Assert.AreEqual("Ошибка: нет такого месяца", result);


        }
    }
}
