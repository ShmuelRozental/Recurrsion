using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurrsion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int length = arr.Length;
            int a = RecorsiveMethods.FindMax(arr, 0);
            int b = RecorsiveMethods.reversed( 123) ;
            Console.WriteLine(a);
            Console.ReadLine();

            int[] array = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int maxSum = Complexity.FindMaxSubarraySum(array);
            Console.WriteLine("Maximum subarray sum: " + maxSum);



        }
    }
}
