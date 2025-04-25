using System;

class Notebook
{
    private string title;   // Название тетради
    private int sheets;     // Количество листов

    // Конструктор с параметрами
    public Notebook(string title, int sheets)
    {
        this.title = title;
        this.sheets = sheets;
    }

    // Методы доступа к закрытым полям
    public string GetTitle() => title;
    public int GetSheets() => sheets;

    // Метод для получения стоимости тетради
    public virtual int GetCost()
    {
        return 15;
    }

    // Вывод информации
    public void PrintInfo()
    {
        Console.WriteLine($"Тетрадь: {title}, Листов: {sheets}, Стоимость: {GetCost()} руб.");
    }
}

// Производный класс
class SpecialNotebook : Notebook
{
    private string coverType; // Тип обложки

    // Конструктор с параметрами
    public SpecialNotebook(string title, int sheets, string coverType)
        : base(title, sheets)
    {
        this.coverType = coverType;
    }

    // Метод доступа к закрытому полю
    public string GetCoverType() => coverType;

    // Переопределение метода GetCost (увеличение цены)
    public override int GetCost()
    {
        return base.GetCost() + 5;
    }

    // Вывод информации о потомке
    public new void PrintInfo()
    {
        Console.WriteLine($"Специальная тетрадь: {GetTitle()}, Листов: {GetSheets()}, Обложка: {coverType}, Стоимость: {GetCost()} руб.");
    }
}

// Тестирующая программа
class Program
{
    static void Main()
    {
        // Создание объекта базового класса
        Notebook basicNotebook = new Notebook("Школьная", 48);
        basicNotebook.PrintInfo();

        Console.WriteLine();

        // Создание объекта производного класса
        SpecialNotebook specialNotebook = new SpecialNotebook("Университетская", 80, "Твёрдая");
        specialNotebook.PrintInfo();

        Console.WriteLine("\nПроверка методов:");
        Console.WriteLine($"Название: {specialNotebook.GetTitle()}");
        Console.WriteLine($"Количество листов: {specialNotebook.GetSheets()}");
        Console.WriteLine($"Тип обложки: {specialNotebook.GetCoverType()}");
    }
}