﻿namespace Lab6;

public class Refrigerator
{
    private EmbeddedMicroprocessor microprocessor;
    private ElectricalEquipment electricalEquipment;
    private RefrigeratorCabinet refrigeratorCabinet;
    private List<Product> products = new List<Product>();

    public Refrigerator(EmbeddedMicroprocessor microprocessor, ElectricalEquipment electricalEquipment, 
        RefrigeratorCabinet refrigeratorCabinet)
    {
        this.microprocessor = microprocessor;
        this.electricalEquipment = electricalEquipment;
        this.refrigeratorCabinet = refrigeratorCabinet;
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
    
    // Метод для додавання продукту в холодильник
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Метод для видалення продукту з холодильника
    public void RemoveProduct(Product product)
    {
        products.Remove(product);
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
}