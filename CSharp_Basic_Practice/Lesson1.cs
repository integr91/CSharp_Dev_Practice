// Урок 1: Типы данных и переменные

public class Lesson1 : BaseLesson
{
    protected override (string name, Action task)[] GetTasks() => new (string, Action)[]
    {
        ("Задание 1: Поменять местами две переменные int", SwapValues),
        ("Задание 2 (*): Обмен без третьей переменной", SwapWithoutTemp),
        ("Задание 3: Сумма и произведение цифр числа", SumAndProduct),
        ("Задание 4 (*): Приветствие с именем и возрастом", GreetUser),
        ("Задание 5 (*): Конвертер времени — секунды → часы:минуты:секунды", ConvertTime),
        ("Задание 6 (*): Конвертер из десятичной в двоичную систему", ToBinary),
    };

    // Задание 1: поменять местами значения двух переменных int
    private void SwapValues()
    {
        int a = 20;
        int b = 10;
        int f ;
        Console.WriteLine($"Число {a},{b}");
        f = a;
        a = b;
        b = f;
        Console.WriteLine($"Число {a},{b}");
    }

    // Задание 2 (*): поменять местами два int без третьей переменной
    private void SwapWithoutTemp()
    {
        int a = 3;
        int b = 8;
        Console.WriteLine($"{a},{b}");
        a = a+b;
        b = b-a;
        a = a+b;
        b = -b;
        Console.WriteLine($"{a},{b}");
    }

    // Задание 3: вычислить сумму и произведение цифр числа
    // Формат вывода: "Сумма = {x}, Произведение = {y}"
    private void SumAndProduct()
    {
        int x = 10;
        int y = 20;
        x += y;
        y *= x;
        Console.WriteLine($"{x} {y}");
        // Цикл
    }

    // Задание 4 (*): запросить имя и возраст пользователя, вывести строку приветствия
    private void GreetUser()
    {
        
    }

    // Задание 5 (*): конвертер времени — секунды → часы:минуты:секунды
    private void ConvertTime()
    {
        
    }

    // Задание 6 (*): конвертер из десятичной системы счисления в двоичную
    private void ToBinary()
    {
        // Цикл
    }
}
