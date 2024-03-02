using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        public static int[] arr1;
        static void f1()
        {
            int[] arr = InputArray();
            Console.WriteLine("Array before sorting: ");
            PrintArray(arr);
            arr1 = ArrayToArray(arr);
            ShellSort(arr);
            Console.WriteLine("Array after sorting: ");
            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        
        #region FirstTask

        static int[] InputArray()
        {
            Console.WriteLine("Insert quantity of items in array: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert minimum of array: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert maximum of array: ");
            int max = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] arr = new int[quantity];
            for (int i = 0; i < quantity; i++)
            {
                arr[i] = random.Next(min, max);
            }

            return arr;
        }



        static void ShellSort(int[] arr)
        {
            int gap = arr.Length / 2;
            while (gap > 0)
            {
                for (int i = gap; i < arr.Length; i++)
                {
                    int temp = arr[i];
                    int j = i;
                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }
                    arr[j] = temp;
                }
                gap /= 2;
            }
        }
        
        #endregion

        static void f2()
        {
            Console.WriteLine("Enter the upper limit:");
            int n = Convert.ToInt32(Console.ReadLine());
            bool[] marked = CalculateMarkedArray(n);
            PrintPrimeNumbers(n, marked);
        }

        #region SecondTask

        static bool[] CalculateMarkedArray(int n)
        {
            bool[] marked = new bool[(n - 2) / 2 + 1];
            int limit = (n - 2) / 2;
    
            for (int i = 1; i <= limit; i++)
            {
                for (int j = i; (i + j + 2 * i * j) <= limit; j++)
                {
                    marked[i + j + 2 * i * j] = true;
                }
            }
    
            return marked;
        }

        static void PrintPrimeNumbers(int n, bool[] marked)
        {
            int limit = (n - 2) / 2;
            Console.WriteLine("Prime numbers up to " + n + ":");
            Console.Write("2 ");
    
            for (int i = 1; i <= limit; i++)
            {
                if (!marked[i])
                {
                    Console.Write((2 * i + 1) + " ");
                }
            }
        }

        #endregion

        static void f3()
        {
            Console.WriteLine("Array before min max swap: ");
            PrintArray(arr1);
            Console.WriteLine("Array after min max swap: ");
            MinMaxSwap(arr1);
            PrintArray(arr1);
            Console.WriteLine("Array before first last swap: ");
            PrintArray(arr1);
            Console.WriteLine("Array after first last swap: ");
            SwapFirstAndLast(arr1);
            PrintArray(arr1);
            
        }

        #region ThirdTask

        public static int[] ArrayToArray(int[] arr)
        {
            int[] arr1 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = arr[i];
            }

            return arr1;
        }

        public static void MinMaxSwap(int[] arr)
        {
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[minIndex])
                    minIndex = i;
                if (arr[i] > arr[maxIndex])
                    maxIndex = i;
            }

            int temp = arr[minIndex];
            arr[minIndex] = arr[maxIndex];
            arr[maxIndex] = temp;
        }
        
        static void SwapFirstAndLast(int[] arr)
        {
                int temp = arr[0];
                arr[0] = arr[arr.Length - 1];
                arr[arr.Length - 1] = temp;
        }
        
        #endregion

        static void Main(string[] args)
        {
            f1();
            f3();
        }
    }
}
