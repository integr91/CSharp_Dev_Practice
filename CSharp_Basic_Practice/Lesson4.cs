// Урок 4: Методы

public class Lesson4 : BaseLesson
{
    protected override (string name, Action task)[] GetTasks() => new (string, Action)[]
    {
        ("Задание 2: PrintHello", PrintHello),
        ("Задание 3: PrintMessage", Task3),
        ("Задание 4: IsEven", Task4),
        ("Задание 5: Multiply — перегрузки", Task5),
        ("Задание 6: GreetUser с параметром по умолчанию", Task6),
        ("Задание 7: Swap через ref", Task7),
        ("Задание 8: TryDivide", Task8),
        ("Задание 9 (*): Factorial — рекурсия", Task9),
    };

    // Задание 2: вывести "Hello, World!"
    private void PrintHello()
    {

    }

    // Задание 3: вывести переданное сообщение
    private void Task3()
    {
        
    }

    // Задание 4: вернуть true если число чётное
    private void Task4()
    {

    }

    // Задание 5: умножить три числа
    private void Task5()
    {

    }

    // Задание 6: вывести "{greeting}, {name}!"
    private void Task6()
    {
        
    }

    // Задание 7: поменять местами значения двух аргументов через ref
    private void Task7()
    {
        
    }

    // Задание 8: если value делится на divisor без остатка — присвоить value результат деления, вернуть true
    private void Task8()
    {

    }

    // Задание 9 (*): рекурсивный факториал
    private void Task9()
    {
        
    }
}
