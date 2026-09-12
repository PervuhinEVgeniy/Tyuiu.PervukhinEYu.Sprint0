using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PervuhinEY.Sprin0.Task3.V0Lib;

namespace Tyuiu.PervuhinEY.Sprin0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
