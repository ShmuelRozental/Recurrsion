using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurrsion
{
    public class Complexity
    {
        //o(n)
        public int CalculateOddSum(int[] array)
        {
            int sum = 0;

            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
            }

            return sum;
        }

        //o(n)
        public int FindMaximumTwo(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                throw new ArgumentException("Array must contain at least two elements.");
            }

            int maxSum = array[0] + array[1];

            for (int i = 1; i < array.Length - 1; i++)
            {
                int currentSum = array[i] + array[i + 1];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }

            return maxSum;
        }

        //o(n)
        public bool ContainsNumber(int[] array, int number)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array cannot be null");
            }

            foreach (int num in array)
            {
                if (num == number)
                {
                    return true;
                }
            }

            return false;
        }

        //o(n)
        public int SumOfAllTriplets(int[] array)
        {
            if (array == null || array.Length < 3)
            {
                throw new ArgumentException("Array must contain at least three elements.");
            }

            int maxTripletSum = array[0] + array[1] + array[2];

            for (int i = 1; i < array.Length - 2; i++)
            {
                int currentTripletSum = array[i] + array[i + 1] + array[i + 2];
                if (currentTripletSum > maxTripletSum)
                {
                    maxTripletSum = currentTripletSum;
                }
            }

            return maxTripletSum;
        }

        //o(n)
        public (int, int)? FindLastPairWithProduct(int[] array, int product)
        {
            if (array == null || array.Length < 2)
            {
                throw new ArgumentException("Array must contain at least two elements.");
            }

            (int, int)? lastPair = null;  // To store the last valid pair

            for (int i = 0; i < array.Length - 1; i++)
            {
                int currentProduct = array[i] * array[i + 1];
                if (currentProduct == product)
                {
                    lastPair = (array[i], array[i + 1]);
                }
            }

            return lastPair;
        }

        //o(n)
        public int CountEvenNumbers(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array cannot be null.");
            }

            int count = 0;

            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }

        //O(n+m+klogk)
        public static int[] MergeSortedArraysUnique(int[] array1, int[] array2)
        {
            if (array1 == null || array2 == null)
            {
                throw new ArgumentNullException("Input arrays cannot be null.");
            }

            HashSet<int> uniqueNumbers = new HashSet<int>();
            int i = 0, j = 0;

            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] < array2[j])
                {
                    uniqueNumbers.Add(array1[i]);
                    i++;
                }
                else if (array1[i] > array2[j])
                {
                    uniqueNumbers.Add(array2[j]);
                    j++;
                }
                else
                {
                    uniqueNumbers.Add(array1[i]);
                    i++;
                    j++;
                }
            }

            while (i < array1.Length)
            {
                uniqueNumbers.Add(array1[i]);
                i++;
            }


            while (j < array2.Length)
            {
                uniqueNumbers.Add(array2[j]);
                j++;
            }

            int[] resultArray = new int[uniqueNumbers.Count];
            uniqueNumbers.CopyTo(resultArray);
            Array.Sort(resultArray);
            return resultArray;
        }

        //O(n)
        public static int[] CountFrequency(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array cannot be null.");
            }

            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int number in array)
            {
                if (frequencyMap.ContainsKey(number))
                {
                    frequencyMap[number]++;
                }
                else
                {
                    frequencyMap[number] = 1;
                }
            }

            int[] frequencies = frequencyMap.Values.ToArray();

            return frequencies;
        }

        //o(n)
        public static int FindMaxSubarraySum(int[] array)
        {
            int maxSum = int.MinValue;
            int currentSum = 0;

            foreach (int num in array)
            {
                currentSum += num;

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }


                if (currentSum < 0)
                {
                    currentSum = 0;
                }
            }

            return maxSum;
        }

        //o(n)
        public static int FindFirstRepeating(int[] array)
        {
            HashSet<int> seenNumbers = new HashSet<int>();

            foreach (int num in array)
            {
                if (seenNumbers.Contains(num))
                {
                    return num;
                }
                seenNumbers.Add(num);
            }
            return -1;
        }

        public static int FindMissingNumber(int[] array, int n)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (array[mid] == mid + 1)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left + 1;
        }

        //o(log n)
        public class MissingNumberFinder
        {
            public static int FindMissingNumber(int[] array, int n)
            {
                int left = 0;
                int right = array.Length - 1;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;

                    if (array[mid] == mid + 1)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }

                return left + 1;
            }
        }
        public static int FindMissingNumberUs(int[] unsortedArray, int n)
        {
       
            int expectedSum = n * (n + 1) / 2;

           
            int actualSum = 0;
            foreach (int num in unsortedArray)
            {
                actualSum += num;
            }

          
            return expectedSum - actualSum;
        }
            
    }
}
