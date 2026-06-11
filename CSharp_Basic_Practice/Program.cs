while (true)
{
    Console.Clear();
    Console.WriteLine("=== C# Basic Practice ===");
    Console.Write("Урок (1-9), 0 — выход: ");

    string? input = Console.ReadLine();

    if (!int.TryParse(input, out int choice) || choice < 0 || choice > 9)
    {
        Console.WriteLine("Введите число от 0 до 9.");
        Console.ReadKey();
        continue;
    }

    if (choice == 0) break;

    ILesson lesson = choice switch
    {
        1 => new Lesson1(),
        2 => new Lesson2(),
        3 => new Lesson3(),
        4 => new Lesson4(),
        5 => new Lesson5(),
        6 => new Lesson6(),
        7 => new Lesson7(),
        8 => new Lesson8(),
        9 => new Lesson9(),
        _ => throw new InvalidOperationException()
    };

    Console.WriteLine($"\n--- Урок {choice} ---");
    lesson.ExecuteLesson();
}
