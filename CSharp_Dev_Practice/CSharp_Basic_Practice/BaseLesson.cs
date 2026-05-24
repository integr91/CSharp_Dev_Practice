public abstract class BaseLesson : ILesson
{
    protected abstract (string name, Action task)[] GetTasks();

    public void ExecuteLesson()
    {
        var tasks = GetTasks();

        while (true)
        {
            Console.WriteLine();
            for (int i = 0; i < tasks.Length; i++)
                Console.WriteLine($"  {i + 1}. {tasks[i].name}");

            Console.Write("\nЗадание (0 — назад): ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int choice) || choice < 0 || choice > tasks.Length)
            {
                Console.WriteLine($"Введите число от 0 до {tasks.Length}.");
                continue;
            }

            if (choice == 0) break;

            Console.WriteLine($"\n--- {tasks[choice - 1].name} ---\n");
            tasks[choice - 1].task();
            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
