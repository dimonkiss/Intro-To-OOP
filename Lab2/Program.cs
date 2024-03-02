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
        public static int[,] matrix;
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
        
        #region FirstTask

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
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

        //f4 - f5 незрозумілі завдання 


        static void f6()
        {
            matrix = CreateMatrix();
            PrintMatrix(matrix);
            CheckDeductedStudents(matrix);
            PrintAveragePerStudent(matrix);
            PrintDisciplineWithMaximumAverage(matrix);


        }

        #region SixTask

        static int[,] CreateMatrix()
        {
            Random random = new Random();
            Console.WriteLine("Insert quantity of rows in matrix: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert quantity of cols in matrix: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert minimum of array: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert maximum of array: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(min, max);
                }
            }
            return matrix;
        }
        
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
        static void CheckDeductedStudents(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; ++i)
            {
                int limit = 0;
                for (int j = 0; j < cols; ++j)
                {
                    if (matrix[i, j] < 60)
                    {
                        ++limit;
                    }
                }
                if (limit == cols)
                {
                    Console.WriteLine($"Student {i} deducted for all subjects");
                }
            }
        }
        
        static void PrintAveragePerStudent(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            Console.WriteLine("Avarage per student: ");
            for (int i = 0; i < rows; i++)
            {
                int avg = 0;
                for (int j = 0; j < cols; j++)
                {
                    avg += matrix[i, j];
                }
                Console.Write(avg / cols + " ");
            }
            Console.WriteLine();
        }
        
        static void PrintDisciplineWithMaximumAverage(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int maximumSum = 0;
            int maxColumnIndex = 0;

            for (int i = 0; i < cols; ++i)
            {
                int columnSum = 0;
                for (int j = 0; j < rows; ++j)
                {
                    columnSum += matrix[j, i];
                }
                if (columnSum > maximumSum)
                {
                    maximumSum = columnSum;
                    maxColumnIndex = i;
                }
            }
            Console.WriteLine($"Discipline that has the maximum average is column index {maxColumnIndex}");
        }

        #endregion

        static void f7()
        {
            PrintMatrix(matrix);
            matrix = DeleteMinDisciple(matrix);
            Console.WriteLine();
            PrintMatrix(matrix);
            Console.WriteLine();
            SortAndRearrangeColumns(matrix);
            PrintMatrix(matrix);
            Console.WriteLine("Insert number that you search: ");
            int n = Convert.ToInt32(Console.ReadLine());
            SearchNumber(matrix,n);
        }

        #region SevenTask

        static int[,] DeleteMinDisciple(int[,] matrix)
        {
            int minColumnIndex = 0;
            double minAverage = double.MaxValue;
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int j = 0; j < columns; j++)
            {
                double sum = 0;

                for (int i = 0; i < rows; i++)
                {
                    sum += matrix[i, j];
                }

                double average = sum / rows;

                if (average < minAverage)
                {
                    minAverage = average;
                    minColumnIndex = j;
                }
            }

            Console.WriteLine($"Discipline that has the minimum average is column index {minColumnIndex}");
            
            int[,] result = new int[rows, columns - 1]; 

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0, k = 0; j < columns; j++) 
                {
                    if (j != minColumnIndex)
                    {
                        result[i, k] = matrix[i, j];
                        k++;
                    }
                }
            }

            return result;
        }

        static void SortAndRearrangeColumns(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            
            double[] columnAverages = new double[columns];
            int[] columnIndices = new int[columns];
            for (int j = 0; j < columns; j++)
            {
                double sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum += matrix[i, j];
                }
                double average = sum / rows;
                columnAverages[j] = average;
                columnIndices[j] = j;
            }
            
            SortColumns(columnIndices, columnAverages);
            
            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix[i, columnIndices[j]];
                }
            }
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = result[i, j];
                }
            }
        }
        
        static void SortColumns(int[] columnIndices, double[] columnAverages)
        {
            int n = columnIndices.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (columnAverages[columnIndices[j]] < columnAverages[columnIndices[j + 1]])
                    {
                        // Swap column indices
                        int temp = columnIndices[j];
                        columnIndices[j] = columnIndices[j + 1];
                        columnIndices[j + 1] = temp;
                    }
                }
            }
        }

        static void SearchNumber(int[,] matrix, int n)
        {
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(1); ++j)
                {
                    if (matrix[i, j] == n)
                    {
                        Console.WriteLine($"Number {n} is located on {i} row {j} column");
                    }
                }
            }
        }
        #endregion

        static void Main(string[] args)
        {
            f6();
            f7();
        }
    }
}
