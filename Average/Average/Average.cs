using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    public static class Average
    {
        
        public static double AverageArr(int[] arr)
        {
            long sum = 0;
            if (arr.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            double average = (double) sum / arr.Length;

            return average;
        }

        public static long AverageArr()
        {
            throw new NotImplementedException();
        }

    }
}
