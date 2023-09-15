using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.UleevRI.Sprint0.Task6.V0.Lib;

namespace Tyuiu.UleevRI.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов масиива = " + DataService.AdditionArray(numArray));
            Console.WriteLine("Разность элементов масиива = " + DataService.SubtractionArray(numArray));
            Console.WriteLine("Произведение элементов масиива = " + DataService.MultiplicationArray(numArray));
            Console.ReadKey();
        }
    }
}
