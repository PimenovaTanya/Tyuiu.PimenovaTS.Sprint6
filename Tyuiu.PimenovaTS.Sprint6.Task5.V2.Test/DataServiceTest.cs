using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PimenovaTS.Sprint6.Task5.V2.Lib;

namespace Tyuiu.PimenovaTS.Sprint6.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.PimenovaTS.Sprint6\Tyuiu.PimenovaTS.Sprint6.Task5.V2\bin\Debug\InPutFileTask5V2.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
