using System;

public static class ResearchWork
{
    public static void IndexesInArray()
    {
        Console.WriteLine("Введіть кількість елементів масиву:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть мінімальне значення діапазону:");
        int minValue = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть максимальне значення діапазону:");
        int maxValue = int.Parse(Console.ReadLine());

        int[] array = GenerateArray(n, minValue, maxValue);
        Console.WriteLine("Масив до сортування:");
        PrintArray(array);

        SelectionSort(array);
        Console.WriteLine("Масив після сортування:");
        PrintArray(array);

        int[] unchangedIndexes = FindUnchangedIndexes(array);
        Console.WriteLine($"Значення індексів, що залишилися незмінними після сортування: {string.Join(", ", unchangedIndexes)}");
        Console.WriteLine($"Кількість незмінних індексів: {unchangedIndexes.Length}");
    }

    public static int[] GenerateArray(int n, int minValue, int maxValue)
    {
        Random rand = new Random();
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = rand.Next(minValue, maxValue + 1);
        }
        return array;
    }

    public static void SelectionSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }

    public static int[] FindUnchangedIndexes(int[] array)
    {
        int[] indexes = new int[array.Length];
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            indexes[i] = i;
        }
        return indexes;
    }

    public static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    
    
    public static void ActionsWithMatrix()
    {
        Console.WriteLine("Введіть кількість проектів:");
        int projectsCount = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть кількість місяців:");
        int monthsCount = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть мінімальне значення діапазону прибутку:");
        int minValue = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть максимальне значення діапазону прибутку:");
        int maxValue = int.Parse(Console.ReadLine());

        int[,] matrix = GenerateMatrix(projectsCount, monthsCount, minValue, maxValue);

        Console.WriteLine("Матриця прибутків:");
        PrintMatrix(matrix);

        int[] totalProjectProfits = CalculateTotalProjectProfits(matrix);
        Console.WriteLine("\nЗагальний прибуток від кожного проекту:");
        for (int i = 0; i < totalProjectProfits.Length; i++)
        {
            Console.WriteLine($"Проект {i + 1}: {totalProjectProfits[i]}");
        }

        int totalCompanyProfit = CalculateTotalCompanyProfit(totalProjectProfits);
        Console.WriteLine($"\nЗагальний дохід компанії від усіх проектів за усі місяці: {totalCompanyProfit}");

        int projectWithMaxProfitIndex = FindProjectWithMaxProfitIndex(totalProjectProfits);
        Console.WriteLine($"Індекс проекту з найбільшим прибутком: {projectWithMaxProfitIndex + 1}");
    }

    public static int[,] GenerateMatrix(int projectsCount, int monthsCount, int minValue, int maxValue)
    {
        Random rand = new Random();
        int[,] matrix = new int[projectsCount, monthsCount];
        for (int i = 0; i < projectsCount; i++)
        {
            for (int j = 0; j < monthsCount; j++)
            {
                matrix[i, j] = rand.Next(minValue, maxValue + 1);
            }
        }
        return matrix;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],4}");
            }
            Console.WriteLine();
        }
    }

    public static int[] CalculateTotalProjectProfits(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[] totalProjectProfits = new int[rows];
        for (int i = 0; i < rows; i++)
        {
            int totalProfit = 0;
            for (int j = 0; j < cols; j++)
            {
                totalProfit += matrix[i, j];
            }
            totalProjectProfits[i] = totalProfit;
        }
        return totalProjectProfits;
    }

    public static int CalculateTotalCompanyProfit(int[] totalProjectProfits)
    {
        int totalProfit = 0;
        foreach (int profit in totalProjectProfits)
        {
            totalProfit += profit;
        }
        return totalProfit;
    }

    public static int FindProjectWithMaxProfitIndex(int[] totalProjectProfits)
    {
        int maxProfit = int.MinValue;
        int maxProfitIndex = -1;
        for (int i = 0; i < totalProjectProfits.Length; i++)
        {
            if (totalProjectProfits[i] > maxProfit)
            {
                maxProfit = totalProjectProfits[i];
                maxProfitIndex = i;
            }
        }
        return maxProfitIndex;
    }
    
    public static void ActionsWithString()
    {
        Console.WriteLine("Введіть рядок символів:");
        string input = Console.ReadLine();

        int countOfWordsStartingWithCapital = CountWordsStartingWithCapital(input);
        Console.WriteLine($"Кількість слів, що починаються з великої літери: {countOfWordsStartingWithCapital}");

        string lastLettersOfWords = ExtractLastLettersOfWords(input);
        Console.WriteLine($"Текст, складений з останніх букв усіх слів: {lastLettersOfWords}");
    }

    public static int CountWordsStartingWithCapital(string input)
    {
        string[] words = input.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;
        foreach (string word in words)
        {
            if (char.IsUpper(word[0]))
            {
                count++;
            }
        }
        return count;
    }

    public static string ExtractLastLettersOfWords(string input)
    {
        string[] words = input.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string result = "";
        foreach (string word in words)
        {
            result += word[word.Length - 1];
        }
        return result;
    }
}
