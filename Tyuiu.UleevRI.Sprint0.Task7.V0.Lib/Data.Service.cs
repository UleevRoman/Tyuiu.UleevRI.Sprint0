using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.UleevRI.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] num1, int[] num2)
        {
            int[] num = new int[5];
            for (var i = 0; i < num.Length; i++)
            {
                num[i] = num1[i] + num2[i];
            }
            return num;
        }
    }
}
