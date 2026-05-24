// Урок 4: Методы

public class Lesson4 : BaseLesson
{
    protected override (string name, Action task)[] GetTasks() => new (string, Action)[]
    {
        ("Задание 1: PrintHello", PrintHello),
        ("Задание 2: PrintMessage", Task2),
        ("Задание 3: IsEven", Task3),
        ("Задание 4: Multiply — перегрузки", Task4),
        ("Задание 5: GreetUser с параметром по умолчанию", Task5),
        ("Задание 6: Swap через ref", Task6),
        ("Задание 7: TryDivide", Task7),
        ("Задание 8 (*): Factorial — рекурсия", Task8),
    };

    // Задание 1: вывести "Hello, World!"
    private void PrintHello()
    {
            Console.WriteLine("Hello, World!"); 
    }

    // Задание 2: вывести переданное сообщение
    private void Task2()
    {
        void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        PrintMessage("Hello, World!");
        PrintMessage("ГОЙДА");
        PrintMessage("ЗЕТ ЗЕТ ЗЕТ");
    }

    // Задание 3: вернуть true если число чётное
    private void Task3()
    {
        bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }
        bool isEven = IsEvenNumber(23);
        Console.WriteLine(isEven);
    }

    // Задание 4: умножить три числа
    private void Task4()
    {
        int MultiplyNumbers(int a, int b, int c)
        {
            return a * b * c;
        }
        int a = 10;
        int b = 20;
        int c = 30;
        Console.WriteLine(MultiplyNumbers(a, b, c));
    }

    // Задание 5: вывести "{greeting}, {name}!"
    private void Task5()
    {
        void PrintGreetingMessage(string greeting, string name)
        {
            Console.WriteLine($"{greeting}, {name}!");
        }
        PrintGreetingMessage("Hello, World!","Курица");
    }

    // Задание 6: поменять местами значения двух аргументов через ref
    private void Task6()
    {
        void ChangesInMeaning(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        OutputOfNumbers(a, b);
        ChangesInMeaning(ref a, ref b);
        OutputOfNumbers(a, b);
    }
    private void OutputOfNumbers(int i, int i1)
    {
        Console.WriteLine($"{i} {i1}");
    }

    // Задание 7: если value делится на divisor без остатка — присвоить value результат деления, вернуть true
    private void Task7()
    {
        bool TryDivide(ref int value, int divisor)
        {
            if (divisor == 0)
                return false; // Деление на ноль невозможно
    
            if (value % divisor == 0)
            {
                value = value / divisor;
                return true;
            }
            return false;
        }
        int x;
        x = 23;
        TryDivide(ref x,23);
        Console.WriteLine(x);
    }

    // Задание 8 (*): рекурсивный факториал
    private void Task8()
    {
        long Factorial(int n)
        {
            // Базовое условие выхода из рекурсии
            if (n == 0 || n == 1)
                return 1;
    
            // Рекурсивный вызов: n! = n * (n-1)!
            return n * Factorial(n - 1);
        }
        Console.WriteLine(Factorial(5));
    }
}
