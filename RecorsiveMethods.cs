using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurrsion
{
    internal class RecorsiveMethods
    {

        public static int Multiply(int X, int Y)
        {
            if (Y == 0)
            { 
            return 0; 
            }
            else if (Y > 0)
            {
                return X + Multiply(X, Y - 1);
            }
            else
            {
            return -Multiply(X, --Y);
            }
        }

        public static int SumOfDigit(int x)
        {
            if (x < 10)
            {
                return x;
            }
            else
            {
                return (x %10) + SumOfDigit(x / 10);
            }
        }

        public static int Power(int baseNum, int exponent)
        {
            if (exponent <= 1)
                return baseNum;
            return baseNum * Power(baseNum, exponent - 1);
        }

        public static int reversed(int x)
        {
            if (x < 10)
                return x;
            int lastDigit = (x % 10) ;
            int leftDigit = x / 10;
            int numDigits = (int)Math.Log10(leftDigit) + 1;

            return lastDigit * (int)(Math.Pow(10, numDigits)) + reversed(leftDigit);
        }

         public static int Sum(int[]arr, int length)
         {
            if (length == 0)
                return 0;
            return arr[length - 1] + Sum(arr, length-1);
         }

        public static int Divide(int dividend, int divisor)
        {
            try
            {
                if (divisor == 0)
                    throw new DivideByZeroException("Divisor cannot be zero.");

                if (dividend < divisor)
                    return 0; 

                return 1 + Divide(dividend - divisor, divisor); 
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return -1; 
            }
        }

        public static bool IsPalindrome(string str, int left, int right)
        {
            if (left >= right)
                return true;
            if (str[left] != str[right])
                return false;
            return IsPalindrome(str, left+1, right-1);

        }


        public static int decimalToBinary(int decimalNum)
        {
            if (decimalNum == 0)
                return 0;


            return (decimalNum % 2) + 10 * decimalToBinary(decimalNum / 2);
        }

        public static int gcd (int a, int b)
        {
            if (b == 0)
                return a;
            return gcd(b, a%b);
        }

        public static void evenNumbers (int x)
        {
            if (x <= 0)
                return;
            if (x % 2 != 0)
                x--;

            Console.WriteLine(x);
            evenNumbers(x - 2);
        }

        public static int FindMax(int[] arr, int n)
        {
            if (n == arr.Length -1)
                return arr[n];
            int max = FindMax(arr, n+1);
            return Math.Max(arr[n], max);
        }

        public static int subtracEvenOdd(int num)
        {
            
            if (num == 0)
                return 0;

            int lastDigit = num % 10;

            if (lastDigit % 2 == 0)
            {
                return lastDigit + subtracEvenOdd(num / 10);
            }
            else
            {
                return -lastDigit + subtracEvenOdd(num / 10);
            }
        }


        public static bool sequence(int[] arr, int index)
        {
            if (index == arr.Length - 1)
                return true;

            if (arr[index + 1] - arr[index] != arr[1] - arr[0])
                return false;


            return sequence(arr, index + 1);
        }



    }
}
