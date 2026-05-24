// Урок 2: Условные операторы и циклы

public class Lesson2 : BaseLesson
{
    protected override (string name, Action task)[] GetTasks() => new (string, Action)[]
    {
        ("Задание 2: Сумма чисел от 1 до N", SumUpToN),
        ("Задание 3: День недели по числу (1–7)", DayOfWeek),
        ("Задание 4: Чётное или нечётное", CheckEvenOdd),
        ("Задание 5: Возведение числа в натуральную степень", Power),
        ("Задание 6 (*): Наибольший общий делитель", GCD),
    };

    // Задание 1: запросить число N, вычислить сумму чисел от 1 до N
    private void SumUpToN()
    {
        Console.WriteLine("Сумма чисел от 1 до N");
        {
            int i = 1, n, sum = 0;
            Console.WriteLine("Введите сумму числа N");
            n = Convert.ToInt32(Console.ReadLine());
            while (i <= n)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("Полученная сумма: " + sum);
        }
    }

    // Задание 2: при вводе числа 1–7 вывести день недели
    // При неверном вводе — предупреждение и повторный запрос
    private void DayOfWeek()
    {
Console.WriteLine("Запросите день недели от 1 до 7");
string dayName = Console.ReadLine();
int day = int.Parse(dayName);
switch (day)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Неверный день");
        break;
}
    }

    // Задание 3: определить чётность числа — вывести "Чётное" или "Нечётное"
    private void CheckEvenOdd()
    { 
        Console.WriteLine("Пиши сюда числа и я скажу чётное это или нет");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("Чётное");
        }
        else
        {
            Console.WriteLine("Нечётное");
        }
    }

    // Задание 4: запросить числа A и B, возвести A в натуральную степень B
    private void Power()
    {
        {
            Console.WriteLine("Введите число A:");
            long a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число B:");
            long b = int.Parse(Console.ReadLine());

            long result = 1;
            for (int i = 1; i <= b; i++)
            {
                result = result * a;
            }

            Console.WriteLine($"{a} в степени {b} равно {result}");
        }
    }

    // Задание 5 (*): найти наибольший общий делитель двух целых чисел
    private void GCD()
    {
        Console.WriteLine("Введите число А:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число В:");
        int b = int.Parse(Console.ReadLine());
        int z = 0;
        if (a < b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        if (b == 0)
        {
            Console.WriteLine("Низя так");
            return;
        }
        if (a % b !=0)
        {
                z = (a % b);
                while (b % z != 0)
                { 
                    z = b % z;
                }
        }
        else
        {
            z = b;
        }
        Console.WriteLine($"{z}");
    }
}
