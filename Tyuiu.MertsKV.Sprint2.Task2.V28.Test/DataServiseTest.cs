﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint2.Task2.V28.Lib; 
namespace Tyuiu.MertsKV.Sprint2.Task2.V28.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 4;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
