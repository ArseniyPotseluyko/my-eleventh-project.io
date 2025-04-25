using System;

class A
{
    private int a;
    private int b;

    // Свойство для вычисления выражения над a и b
    public int C => a + b;

    // Конструктор по умолчанию
    public A()
    {
        a = 5;
        b = 10;
    }

    // Конструктор с параметрами
    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    // Вывод информации
    public void PrintInfo()
    {
        Console.WriteLine($"Класс A: a = {a}, b = {b}, C = {C}");
    }
}

// Производный класс B
class B : A
{
    private int d;

    // Свойство для вычисления выражения над a, b, d с оператором switch
    public int C2
    {
        get
        {
            switch (d)
            {
                case 1: return C * 2;
                case 2: return C / 2;
                default: return C + d;
            }
        }
    }

    // Конструктор, наследующий параметры от A
    public B(int a, int b, int d) : base(a, b)
    {
        this.d = d;
    }

    // Собственный конструктор
    public B(int d)
    {
        this.d = d;
    }

    // Вывод информации
    public new void PrintInfo()
    {
        Console.WriteLine($"Класс B: C2 = {C2}, d = {d}");
    }
}

// Тестирующая программа
class Program
{
    static void Main()
    {
        // Создание объекта класса A
        A objA = new A(7, 3);
        objA.PrintInfo();

        Console.WriteLine();

        // Создание объекта класса B с передачей параметров A
        B objB1 = new B(7, 3, 2);
        objB1.PrintInfo();

        Console.WriteLine();

        // Создание объекта класса B с собственным конструктором
        B objB2 = new B(4);
        objB2.PrintInfo();
    }
}
