using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PervuhinEY.Sprint0.Task2.V0.Lib;

namespace Tyuiu.PervuhinEY.Sprint0.Task2.V0.Tset
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessegeValid()
        {
            //Области создания методов тестирования, методов из библиотеки 
            var name = "Евгений";
            var res = DataService.GetMessage(name);


            //вызываем класс Assert и  метод AreEqual
            Assert.AreEqual("Привет, Евгений", res);
        }
    }
}
