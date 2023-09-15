using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.UleevRI.Sprint0.Task7.V0.Lib;

namespace Tyuiu.UleevRI.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Улеев Р.И. | ИИПБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Улеев Р.И. | ИИПБ-23-3                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
            Console.WriteLine("* одинаковых массивов по длине                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] num1 = new int[] { 1, 2, 3, 4, 5};
            Console.WriteLine("Значение элементов массива №1");
            for (int i = 0; i < num1.Length; i ++)
            {
                Console.WriteLine(num1[i] + ", ");
            }
            Console.WriteLine();
            int[] num2 = new int[] { 1, 2, 3, 4, 5};
            Console.WriteLine("Значение элементов массива №1");
            for (int i = 0; i < num2.Length; i++)
            {
                Console.WriteLine(num2[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (num1.Length == num2.Length)
            {
                int[] num = DataService.AdditionArrays(num1, num2);
                Console.WriteLine("Сумма элементов массив равна: ");
                for (int i = 0; i < num.Length; i++)
                {
                    Console.WriteLine(num[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
            }
            Console.ReadKey();
        }
    }
}
