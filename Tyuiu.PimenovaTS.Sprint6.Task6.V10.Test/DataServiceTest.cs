using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PimenovaTS.Sprint6.Task6.V10.Lib;

namespace Tyuiu.PimenovaTS.Sprint6.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Sprint6\InPutFileTask6V10.txt";

            string res = ds.CollectTextFromFile(path);
            string wait = "nXkwQYzgZ LlckTwkpaAGTvLPc ";

            Assert.AreEqual(wait, res);
        }
    }
}
