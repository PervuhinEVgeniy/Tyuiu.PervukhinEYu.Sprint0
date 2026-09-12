using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PervuhinEY.Sprint0.Task2.V0.Lib;

namespace Tyuiu.PervuhinEY.Sprin0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataServuce и метод GetMassage
            //из библиотеки Tyuiu.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Евгений"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
