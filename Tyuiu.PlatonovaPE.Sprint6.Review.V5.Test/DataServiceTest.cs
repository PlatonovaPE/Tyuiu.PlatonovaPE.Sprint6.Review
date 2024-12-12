using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PlatonovaPE.Sprint5.Review.V5.Lib;

namespace Tyuiu.PlatonovaPE.Sprint5.Review.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFileOutPut()
        {
            string path = @"C:\Users\parse\source\repos\Tyuiu.PlatonovaPE.Sprint6.Review\Tyuiu.PlatonovaPE.Sprint6.Review.V5.Lib\bin\Debug\net8.0\OutPutDataFileTask7V5.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V5.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}