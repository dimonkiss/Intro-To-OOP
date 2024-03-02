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
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Swap min and max");
            Console.WriteLine("2. Swap first and last");
            Console.Write("Enter your choice: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Array before min max swap: ");
                        PrintArray(arr1);
                        Console.WriteLine("Array after min max swap: ");
                        MinMaxSwap(arr1);
                        PrintArray(arr1);
                        break;
                    case 2:
                        Console.WriteLine("Array before first last swap: ");
                        PrintArray(arr1);
                        Console.WriteLine("Array after first last swap: ");
                        SwapFirstAndLast(arr1);
                        PrintArray(arr1);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
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
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Generate and print matrix");
            Console.WriteLine("2. Check deducted students");
            Console.WriteLine("3. Print average score per student");
            Console.WriteLine("4. Print discipline with maximum average");
            Console.Write("Enter your choice: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        matrix = CreateMatrix();
                        PrintMatrix(matrix);
                        break;
                    case 2:
                        if(matrix == null)
                        {
                            Console.WriteLine("Matrix is not generated yet.");
                            break;
                        }
                        CheckDeductedStudents(matrix);
                        break;
                    case 3:
                        if(matrix == null)
                        {
                            Console.WriteLine("Matrix is not generated yet.");
                            break;
                        }
                        PrintAveragePerStudent(matrix);
                        break;
                    case 4:
                        if(matrix == null)
                        {
                            Console.WriteLine("Matrix is not generated yet.");
                            break;
                        }
                        PrintDisciplineWithMaximumAverage(matrix);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
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
            if(matrix == null)
            {
                Console.WriteLine("Matrix is not generated yet.");
                return;
            }

            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Print matrix");
            Console.WriteLine("2. Delete min discipline");
            Console.WriteLine("3. Sort and rearrange columns");
            Console.WriteLine("4. Search for a number");
            Console.Write("Enter your choice: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        PrintMatrix(matrix);
                        break;
                    case 2:
                        matrix = DeleteMinDisciple(matrix);
                        Console.WriteLine();
                        PrintMatrix(matrix);
                        break;
                    case 3:
                        SortAndRearrangeColumns(matrix);
                        PrintMatrix(matrix);
                        break;
                    case 4:
                        Console.WriteLine("Insert number that you search: ");
                        int n;
                        if(int.TryParse(Console.ReadLine(), out n))
                        {
                            SearchNumber(matrix, n);
                        }
                        else
                        {
                            Console.WriteLine("Invalid number.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
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

    

        static void f8()
        {
            double epsilon = 0.0000001; // Точність

            // Діапазон від -2 до 0
            double rootInRangeNegative = FindRootInRange(-2, 0, epsilon);
            Console.WriteLine($"Корінь рівняння у діапазоні від -2 до 0: {rootInRangeNegative}");
            Console.WriteLine($"Підставивиши корінь в рівняння: {Function(rootInRangeNegative)}");

            // Діапазон від 0 до 2
            double rootInRangePositive = FindRootInRange(0, 2, epsilon);
            Console.WriteLine($"Корінь рівняння у діапазоні від 0 до 2: {rootInRangePositive}");
            Console.WriteLine($"Підставивиши корінь в рівняння: {Function(rootInRangePositive)}");

            // Діапазон від 3 до 4
            double rootInRangeAnother = FindRootInRange(3, 4, epsilon);
            Console.WriteLine($"Корінь рівняння у діапазоні від 3 до 4: {rootInRangeAnother}");
            Console.WriteLine($"Підставивиши корінь в рівняння: {Function(rootInRangeAnother)}");
        }

        #region EightTask

        static double Function(double x)
        {
            return Math.Pow(x, 3) - 4 * Math.Pow(x, 2) + 6;
        }
        static double FindRootInRange(double a, double b, double epsilon)
        {
            if (Function(a) * Function(b) >= 0)
            {
                Console.WriteLine($"Метод бісекції не може бути застосований для діапазону від {a} до {b}, оскільки на його кінцях функція має однаковий знак.");
                return double.NaN;
            }

            double c;
            int iterations = 0;

            do
            {
                c = (a + b) / 2;
                if (Function(c) == 0)
                    break;
                else if (Function(c) * Function(a) < 0)
                    b = c;
                else
                    a = c;

                iterations++;
            } while (Math.Abs(b - a) >= epsilon);

            return c;
        }

        #endregion

        static void f9()
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Split input into words");
            Console.WriteLine("2. Sort words by length");
            Console.WriteLine("3. Sort words by first character");
            Console.Write("Enter your choice: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                string input;
                string[] words;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a string of words separated by spaces:");
                        input = Console.ReadLine();
                        words = SplitInputIntoWords(input);
                        Console.WriteLine("Words: ");
                        PrintWords(words);
                        break;
                    case 2:
                        Console.WriteLine("Enter a string of words separated by spaces:");
                        input = Console.ReadLine();
                        words = SplitInputIntoWords(input);
                        SortWordsByLength(words);
                        Console.WriteLine("Words sorted by length: ");
                        PrintWords(words);
                        break;
                    case 3:
                        Console.WriteLine("Enter a string of words separated by spaces:");
                        input = Console.ReadLine();
                        words = SplitInputIntoWords(input);
                        SortWordsByFirstCharacter(words);
                        Console.WriteLine("Words sorted by first character: ");
                        PrintWords(words);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }


        #region NineTask

        static string[] SplitInputIntoWords(string input)
        {
            int wordCount = 1;
            string[] words = new string[wordCount];
            int temp = 0;
            string word;
            for (int i = 0; i < input.Length; ++i)
            {
                word = "";
                if (input[i] == ' ')
                {
                    for (int j = temp; j < i; ++j)
                    {
                        word += input[j];
                    }

                    Array.Resize(ref words, ++wordCount);
                    words[wordCount - 2] = word;
                    temp = i + 1;
                }
            }

            word = "";
            for (int j = temp; j < input.Length; ++j)
            {
                word += input[j];
            }
            words[wordCount - 1] = word;

            return words;
        }

        static void SortWordsByLength(string[] words)
        {
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = 0; j < words.Length - 1 - i; j++)
                {
                    if (words[j].Length < words[j + 1].Length)
                    {
                        string temp1 = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = temp1;
                    }
                }
            }
        }

        static void SortWordsByFirstCharacter(string[] words)
        {
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = 0; j < words.Length - 1 - i; j++)
                {
                    if (words[j][0] > words[j + 1][0])
                    {
                        string temp1 = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = temp1;
                    }
                }
            }
        }

        static void PrintWords(string[] words)
        {
            foreach (var w in words)
            {
                Console.WriteLine(w);
            }
        }

        #endregion
        static void Main(string[] args)
        {
            bool exit = false;
            bool f1Done = false;
            bool f6Done = false;

            while (!exit)
            {
                Console.WriteLine("Choose a function to execute:");
                Console.WriteLine("1. Sort an array");
                Console.WriteLine("2. Print prime numbers");
                Console.WriteLine("3. Swap elements in an array");
                Console.WriteLine("4. Process matrix");
                Console.WriteLine("5. Process matrix and search number");
                Console.WriteLine("6. Find roots of an equation");
                Console.WriteLine("7. Process strings");
                Console.WriteLine("8. Exit");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            f1();
                            f1Done = true;
                            break;
                        case 2:
                            if (f1Done)
                                f2();
                            else
                                Console.WriteLine("Function 1 must be executed first.");
                            break;
                        case 3:
                            if (f1Done)
                                f3();
                            else
                                Console.WriteLine("Function 1 must be executed first.");
                            break;
                        case 4:
                            f6();
                            f6Done = true;
                            break;
                        case 5:
                            if (f6Done)
                                f7();
                            else
                                Console.WriteLine("Function 4 must be executed first.");
                            break;
                        case 6:
                            f8();
                            break;
                        case 7:
                            f9();
                            break;
                        case 8:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 8.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        
    }
}
