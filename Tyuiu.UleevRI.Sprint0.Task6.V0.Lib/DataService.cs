using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.UleevRI.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] num)
        {
            var total = 0;
            for (var i = 0; i < num.Length; i++)
            {
                total += num[i];
            }
            return total;
        }
        public static object SubtractionArray(int[] num)
        {
            var total = 0;
            int i = 0;
            while (i < num.Length)
            {
                total -= num[i];
                i++;
            }
            return total;
        }
        public static object MultiplicationArray(int[] num)
        {
            var total = 1;
            int i= 0;
            do
            {
                total *= num[i];
                i++;
            }
            while (i < num.Length);

            return total;
        }
    } 
}
