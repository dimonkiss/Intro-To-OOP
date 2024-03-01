    using System;
using System.Runtime.InteropServices;
using System.Text;

class Program
{
    public static void f1()
    {
        Console.WriteLine("Висота ромба, проведена з вершини тупого кута, ділить\nсторону навпіл. Знайдіть меншу діагональ, якщо значення периметра\nромба введене з клавіатури\n");
        Console.WriteLine("Введіть периметр ромба:");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть висоту ромба:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Обчислюємо меншу діагональ
        double diagonal2 = Math.Abs(2 * Math.Sqrt(Math.Pow(perimeter / 2, 2) - Math.Pow(height, 2)));

        Console.WriteLine($"Менша діагональ ромба: {diagonal2}");
    }

    public static void f2()
    {
        Console.WriteLine("За даними, що введені з консолі, визначити значення виразу,\nвикористовуючи математичні функції класу Math, і вивести результат\nна консоль.\n");
        Console.WriteLine("e^a*sqrt(((sin a)^2)/ln(2 + b))+tg(a/b)");
        Console.WriteLine();
        Console.WriteLine("Введіть число a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть число b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        double x = Math.Pow(Math.E, a) * Math.Sqrt(Math.Pow(Math.Sin(a), 2) / Math.Log(2 + b)) + Math.Tan(a / b);
        Console.WriteLine($"Результат данного виразу: {x}");
    }
    public static void f3()
    {
        Console.WriteLine("За даними a, x, значення яких ввести з консолі, обчислити значення функції");
        Console.WriteLine("     { -ax, -1 <= x < 1, a > 0");
        Console.WriteLine("f(x)={ a - x, x > 1 , a < 0");
        Console.WriteLine("     { a/x, x = 1 , a = 0");
        Console.WriteLine("Введіть число a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть число x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double f = 0;
        if (x >= -1 && a > 0)
        {
            f = -a * x;
        }
        else if (x > 1 && a < 0)
        {
            f = a - x;
        }
        else if (x == 1 && a == 0)
        {
            f = a / x;
        }
        Console.WriteLine($"Значення функції: {f}");

    }
    public static void f4()
    {
        Console.WriteLine("Написати метод, який в залежності від назви кольору у спектрі\n(червоний, помаранчевий, жовтий, зелений, блакитний, синій,\nфіолетовий) виводить його порядковий номер і код RGB.");
        Console.WriteLine();
        Console.WriteLine("Введіть колір: ");
    
        // Конвертуємо назву кольору у нижній регістр для порівняння
        string colorName = Console.ReadLine().ToLower();
    
        // Пошук порядкового номеру та коду RGB кольору
        int index;
        string rgbCode;
    
        // Використання конструкції switch для визначення кольору
        switch (colorName)
        {
            case "червоний":
                index = 0;
                rgbCode = "FF0000";
                break;
            case "помаранчевий":
                index = 1;
                rgbCode = "FFA500";
                break;
            case "жовтий":
                index = 2;
                rgbCode = "FFFF00";
                break;
            case "зелений":
                index = 3;
                rgbCode = "008000";
                break;
            case "блакитний":
                index = 4;
                rgbCode = "00FFFF";
                break;
            case "синій":
                index = 5;
                rgbCode = "0000FF";
                break;
            case "фіолетовий":
                index = 6;
                rgbCode = "800080";
                break;
            default:
                Console.WriteLine("Кольору з такою назвою у спектрі не існує.");
                return;
        }
    
        // Виведення порядкового номеру та коду RGB
        Console.WriteLine($"Порядковий номер кольору {colorName}: {index + 1}");
        Console.WriteLine($"Код RGB кольору {colorName}: #{rgbCode}");
    }

    public static void f5()
    {
        Console.WriteLine("Дано натуральне число n і дійсне число x >0. Обчислити суму членів ряду: ");
        Console.WriteLine();
        Console.WriteLine("S = E(n, i = 1)(((-1)^i * x^i)/(i+1)(1 + x^i))");
        Console.WriteLine();
        Console.WriteLine("Введіть натуральне число n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть дійсне число x більше 0 :");
        double x = Convert.ToDouble(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i < n; i++)
        {
            sum += (Math.Pow(-1, i)) * Math.Pow(x, i) / ((i + 1) * (1 + Math.Pow(x, i)));
        }
        Console.WriteLine($"Сума членів ряду: {sum}");

    }
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int choice = 9;
        while (choice != 0)
        {
            Console.Clear(); // Очистка консолі
            Console.WriteLine("Кісіль Дмитро \t14 \tІПЗ-11/2 \t1-курс \tdklxwa@knu.ua\n\n");
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Обчислення меншої діагоналі ромба");
            Console.WriteLine("2. Обчислення виразу");
            Console.WriteLine("3. Обчислення значення функції");
            Console.WriteLine("4. Інформація про колір");
            Console.WriteLine("5. Обчислення суми ряду");
            Console.WriteLine("0. Вихід");
            Console.WriteLine("Оберіть опцію:");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    f1();
                    break;
                case 2:
                    f2();
                    break;
                case 3:
                    f3();
                    break;
                case 4:
                    f4();
                    break;
                case 5:
                    f5();
                    break;
                case 0:
                    Console.WriteLine("Програма завершена.");
                    break;
                default:
                    Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                    break;
            }
            Console.WriteLine(); // Порожній рядок для розділення між ітераціями меню
            Console.WriteLine("Натисніть будь-яку клавішу для продовження...");
            Console.ReadKey(); // Очікування введення користувачем будь-якої клавіші перед очищенням консолі
        }
    }
}
