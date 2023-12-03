using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint6.Task3.V3.Lib;

namespace Tyuiu.PimenovaTS.Sprint6.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] job = new int[5, 5] { { -18, 21, 10, -2, 12 }, { -18, -10, 33, -20, 32 }, { 14, -15, -14, 12, -18 }, { -19, 5, -3, 28, -17 }, { -14, -9, 23, -13, 11 } };
            int[,] res = ds.Calculate(job);
            int[,] wait = new int[5, 5] { { -18, -15, 10, -2, 12 }, { -18, -10, 33, -20, 32 }, { 14, -9, -14, 12, -18 }, { -19, 5, -3, 28, -17 }, { -14, 21, 23, -13, 11 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
