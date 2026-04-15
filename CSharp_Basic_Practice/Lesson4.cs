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

    }

    // Задание 2: вывести переданное сообщение
    private void Task2()
    {
        
    }

    // Задание 3: вернуть true если число чётное
    private void Task3()
    {

    }

    // Задание 4: умножить три числа
    private void Task4()
    {

    }

    // Задание 5: вывести "{greeting}, {name}!"
    private void Task5()
    {
        
    }

    // Задание 6: поменять местами значения двух аргументов через ref
    private void Task6()
    {
        
    }

    // Задание 7: если value делится на divisor без остатка — присвоить value результат деления, вернуть true
    private void Task7()
    {

    }

    // Задание 8 (*): рекурсивный факториал
    private void Task8()
    {
        
    }
}
