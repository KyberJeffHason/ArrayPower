using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPower
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int power = 2;
            powerArray(myArray, power);
        }

        public static int[] powerArray(int[] arr, int power)
        {
            int[] ourArray = arr;

            var newArray = ourArray
                .Select(h => (int)Math.Pow(h, power));

            return newArray.ToArray();
        }
    }
}
