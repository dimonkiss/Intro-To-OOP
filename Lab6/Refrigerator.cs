namespace Lab6;

// Делегат для обробки подій про закінчення продуктів
public delegate void ProductRunOutEventHandler(object sender, ProductRunOutEventArgs e);

// Аргументи події про закінчення продуктів
public class ProductRunOutEventArgs : EventArgs
{
    public string ProductName { get; }

    public ProductRunOutEventArgs(string productName)
    {
        ProductName = productName;
    }
}

public class Refrigerator
{
    private int maxTemperature;
    private int minTemperature;
    private EmbeddedMicroprocessor microprocessor;
    private ElectricalEquipment electricalEquipment;
    private RefrigeratorCabinet refrigeratorCabinet;
    private List<Product> products = new List<Product>();

    public Refrigerator(EmbeddedMicroprocessor microprocessor, ElectricalEquipment electricalEquipment, 
        RefrigeratorCabinet refrigeratorCabinet,int maxTemperature, int minTemperature)
    {
        this.microprocessor = microprocessor;
        this.electricalEquipment = electricalEquipment;
        this.refrigeratorCabinet = refrigeratorCabinet;
        this.maxTemperature = maxTemperature;
        this.minTemperature = minTemperature;
    }
    
    public List<Product> Products
    {
        get { return products; }
        set { products = value; }
    }
    
    public EmbeddedMicroprocessor Microprocessor
    {
        get { return microprocessor; }
        set { microprocessor = value; }
    }

    public ElectricalEquipment ElectricalEquipment
    {
        get { return electricalEquipment; }
        set { electricalEquipment = value; }
    }

    public RefrigeratorCabinet RefrigeratorCabinet
    {
        get { return refrigeratorCabinet; }
        set { refrigeratorCabinet = value; }
    }
    // Подія про закінчення продуктів
    public event ProductRunOutEventHandler ProductRunOut;

    // Метод для спровокування події про закінчення продуктів
    protected virtual void OnProductRunOut(string productName)
    {
        ProductRunOut?.Invoke(this, new ProductRunOutEventArgs(productName));
    }
    
    // Метод для додавання продукту в холодильник
    public void AddProduct(Product product)
    {
        try
        {
            products.Add(product);
        }
        catch (IndexOutOfRangeException ex)
        {
            // Обробка вихіду за межі масиву
            Console.WriteLine("Вихід за межі масиву: " + ex.Message);
        }

    }

    // Метод для видалення продукту з холодильника
    public void RemoveProduct(Product product)
    {
        products.Remove(product);
        // Якщо продукт був видалений і холодильник став пустим, спровокуємо подію про закінчення продуктів
        if (products.Count == 0)
        {
            OnProductRunOut(product.Name);
        }
    }
    
    // Інвентаризація продуктів у холодильнику
    public void Inventory()
    {
        Console.WriteLine("Продукти у холодильнику:");

        foreach (var product in products)
        {
            Console.WriteLine($"Назва: {product.Name}, Термін придатності: {product.ExpiryDate}");
        }
    }
    
    // Нагадування про терміни придатності
    public void CheckExpiryDates()
    {
        foreach (var product in products)
        {
            if (product.ExpiryDate < DateTime.Today)
            {
                Console.WriteLine($"Продукт \"{product.Name}\" застарів! Термін придатності: {product.ExpiryDate}");
            }
        }
    }
    
    // Автоматичне регулювання температури
    public void AdjustTemperature()
    {
        // Автоматичне регулювання температури  для кожного продукту
        foreach (var product in products)
        {
            double targetTemperature = 0;
            // Визначення оптимальних параметрів для кожного типу продукту
            switch (product.Name)
            {
                case "М'ясо":
                    targetTemperature += 2;  // Температура для м'яса
                    break;
                case "Овочі":
                    targetTemperature -= 8;  // Температура для овочів
                    break;
                // Додайте інші випадки для різних типів продуктів
                default:
                    break;
            }

            // Застосування оптимальних параметрів 
            electricalEquipment.Thermostat.Temperature = targetTemperature;
        }

        Console.WriteLine("Автоматично регулюємо температуру ...");
    }
    
    // Рекомендації з харчування на основі наявних продуктів
    public void ProvideDietRecommendations()
    {
        // Перевіряємо наявність продуктів в холодильнику
        if (products.Count == 0)
        {
            Console.WriteLine("У холодильнику відсутні продукти. Додайте продукти для отримання рекомендацій.");
            return;
        }

        // Створюємо список доступних категорій продуктів
        var categories = products.Select(p => p.Name).Distinct().ToList();

        // Виводимо наявні продукти у холодильнику
        Console.WriteLine("Ваші продукти у холодильнику:");

        foreach (var name in categories)
        {
            Console.WriteLine($"Категорія: {name}");

            foreach (var product in products.Where(p => p.Name == name))
            {
                Console.WriteLine($"- {product.Name}");
            }
        }

        // Задаємо деякі прості рекомендації щодо створення сніданків
        Console.WriteLine("\nРекомендації для сніданку:");

        if (products.Any(p => p.Name == "Фрукти"))
        {
            Console.WriteLine("- Додайте фрукти до сніданку для вітамінного заряду.");
        }

        if (products.Any(p => p.Name == "Яйця"))
        {
            Console.WriteLine("- Приготуйте яйця у будь-якому вигляді (варені, смажені тощо).");
        }

        if (products.Any(p => p.Name == "Хліб"))
        {
            Console.WriteLine("- Зробіть сендвічі або тост з наявного хліба.");
        }

        Console.WriteLine("\nБажаємо смачного сніданку!");
    }
    
    // Метод для включення холодильника
    public void TurnOn()
    {
        Console.WriteLine("Холодильник увімкнено.");
    }

    // Метод для моделювання збою в роботі холодильника
    public void SimulateMalfunction()
    {
        throw new RefrigeratorMalfunctionException("Компресор вийшов з ладу.");
    }

    // Метод для відкриття дверцят холодильника
    public void OpenDoor()
    {
        Console.WriteLine("Дверцята холодильника відкриті.");
    }
}