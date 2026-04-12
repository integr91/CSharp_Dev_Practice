// Урок 1: Типы данных и переменные

using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

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
        int a = 10;
        int b = 20;
        int c;
        c = a;
        a = b;
        b = c;
        Console.WriteLine($"Число a-{a}, b-{b}");
    }

    // Задание 2 (*): поменять местами два int без третьей переменной
    private void SwapWithoutTemp()
    {
        int a = 10;
        int b = 45;
        a = a + b;
        b = a - b;
        a = a - b;
        b = b;
        Console.WriteLine($"Число a-{a}, b-{b}");
    }

    // Задание 3: вычислить сумму и произведение цифр числа
    // Формат вывода: "Сумма = {x}, Произведение = {y}"
    private void SumAndProduct()
    {
        int a = 37;
        int b = 14;
        int x = a + b;
        int y = a * b;
        Console.WriteLine($"Сумма x-{x}, Произведение y-{y}");
    }

    // Задание 4 (*): запросить имя и возраст пользователя, вывести строку приветствия
    private void GreetUser()
    {
                Console.WriteLine("Введите ваше имя:");
                string name = Console.ReadLine();
                Console.WriteLine("Введите ваш возраст:");
                string ageInput = Console.ReadLine();
                int age;
                if (int.TryParse(ageInput, out age))
                    Console.WriteLine($"Привет, {name}! Вам {age} лет.");
                else
                    Console.WriteLine("Ошибка: введите корректный возраст (число).");
    }

    // Задание 5 (*): конвертер времени — секунды → часы:минуты:секунды
    private void ConvertTime()
    {
        Console.WriteLine("Дарова хуилыга ты мне время написать должен в секундах");
        string seconds = Console.ReadLine();
        int minites =  int.Parse(seconds)/60;
        int hours = int.Parse(seconds)/3600;
            Console.WriteLine(
                $"Держи время в секундах конченный: {seconds} " +
                $"А это тебе нахуй в минутах: {minites} " +
                $"Ещё вот держи в часах: {hours}");
    }

    // Задание 6 (*): конвертер из десятичной системы счисления в двоичную
    private void ToBinary()
    {
        Console.WriteLine("Ну типа привет давай пиши сюда циферки я тебе двоичный код сделаю");
        string number = Console.ReadLine();
        int numberAsInt = int.Parse(number);
        string binary = Convert.ToString(numberAsInt, 2);
        Console.WriteLine($"Вот ваш ответ:{binary}");
    }
}
