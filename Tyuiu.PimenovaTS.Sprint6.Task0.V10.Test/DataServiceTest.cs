using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint6.Task0.V10.Lib;

namespace Tyuiu.PimenovaTS.Sprint6.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int x = 3;
            double res = ds.Calculate(x);
            double wait = 37.56;
            Assert.AreEqual(wait, res);
        }
    }
}
