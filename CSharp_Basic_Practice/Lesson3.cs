// Урок 3: Массивы и коллекции

public class Lesson3 : BaseLesson
{
    protected override (string name, Action task)[] GetTasks() => new (string, Action)[]
    {
        ("Задание 1: Вывести размер и содержимое списка", PrintList),
        ("Задание 2: Сортировка массива по убыванию и возрастанию", SortArray),
        ("Задание 3 (*): Минимум, максимум и среднее значение", FindMinMaxAvg),
        ("Задание 4: Словарь месяцев (1–12)", MonthDictionary),
        ("Задание 5: Объединение двух словарей", MergeDictionaries),
        ("Задание 6: Удаление дублирующихся значений из словаря", RemoveDuplicateValues),
    };

    // Задание 1: вывести размер списка и его содержимое
    private void PrintList()
    {
        List<string> months = new List<string>
        {
            "Мауварь", "Мяуфрель", "Мяумарт",
            "Мяупрель", "Мяумай", "Мяуюнь",
            "Мяуюль", "Мяавагуст", "Мяунтябрь",
            "Мявтябрь", "Мяуябрь", "Мяуркабарь"
        };
        Console.WriteLine("Размер списка: " + months.Count);
        Console.WriteLine("Содержимое списка:");
        foreach (string month in months)
        {
            Console.WriteLine(month);
        }
    }

    // Задание 2: отсортировать массив из N целых чисел по убыванию и по возрастанию
    private void SortArray()
    {
        {
            int[] numbers = { 30, 34, -25, 12, 22, 11, 55 };
            int n = numbers.Length;
            Console.WriteLine("Исходный массив:");
            PrintArray(numbers);
            Array.Sort(numbers);
            Console.WriteLine("\nМассив по возрастанию:");
            PrintArray(numbers);
            Array.Reverse(numbers);
            Console.WriteLine("\nМассив по убыванию:");
            PrintArray(numbers);
        } 
        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }

    // Задание 3 (*): найти минимум, максимум и среднее значение в списке
    // Формат вывода: "Индекс : Значение"
    private void FindMinMaxAvg()
    {
        {
            int[] numbers = { 10, 3, 25, 7, 15, 2 };
            if (numbers.Length == 0)
            {
                Console.WriteLine("Список пуст!");
                return;
            }
            int minIndex = Array.IndexOf(numbers, numbers.Min());
            int maxIndex = Array.IndexOf(numbers, numbers.Max());
            double average = numbers.Average();
            Console.WriteLine($"Минимум: {minIndex} : {numbers[minIndex]}");
            Console.WriteLine($"Максимум: {maxIndex} : {numbers[maxIndex]}");
            Console.WriteLine($"Среднее: {average:F2}");
        }
    }

    // Задание 4: создать словарь номер месяца (1–12) → название месяца; вывести
    private void MonthDictionary()
    {
        Dictionary<int, string> mounth = new Dictionary<int, string>()
        {
            { 1, "Мауварь" },
            { 2, "Мяуфрель" },
            { 3, "Мяумарт" },
            { 4, "Мяупрель" },
            { 5, "Мяумай" },
            { 6, "Мяуюнь" },
            { 7, "Мяуюль" },
            { 8, "Мяавагуст" },
            { 9, "Мяунтябрь" },
            { 10, "Мявтябрь" },
            { 11, "Мяуябрь" },
            { 12, "Мяуркабарь" }
        };
        Console.WriteLine("Размер списка: " + mounth.Count);
        Console.WriteLine("Содержимое списка: ");
        PrintDictionary(mounth);
    }

    // Задание 5: объединить два Dictionary<string, int>
    // При совпадении ключей — взять большее из двух значений
    private void MergeDictionaries()
    {
        {
            Dictionary<string, int> dict1 = new Dictionary<string, int>
            {
                {"Яблоко", 5},
                {"Гвозди", 3},
                {"Брус", 8},
                {"Водопады", 2}
            };

            Dictionary<string, int> dict2 = new Dictionary<string, int>
            {
                {"Яблоко", 7},
                {"Гвозди", 4},
                {"Брус", 6},
                {"Водопады", 9}
            };
            Dictionary<string, int> result = new Dictionary<string, int>(dict1);
            foreach (KeyValuePair<string, int> kvp in dict2)
            {
                if (result.ContainsKey(kvp.Key))
                {
                    int existingValue = result[kvp.Key];
                    int newValue = kvp.Value;
                    result[kvp.Key] = Math.Max(existingValue, newValue);
                }
                else
                {
                    result.Add(kvp.Key, kvp.Value);
                }
            }
            Console.WriteLine("Результат объединения:");
            PrintDictionary(result);
        }
    }

    // Задание 6: удалить из Dictionary<string, int> элементы с повторяющимися значениями
    private void RemoveDuplicateValues()
    {
        Dictionary<string, int> myDict = new Dictionary<string, int>
        {
            {"a", 1},
            {"b", 2},
            {"c", 1},
            {"d", 3},
            {"e", 2},
            {"f", 4}
        };
        Console.WriteLine("До удаления дубликатов:");
        PrintDictionary(myDict);
        HashSet<int> seenValues = new HashSet<int>();
        List<string> keysToRemove = new List<string>();
        foreach (KeyValuePair<string, int> kvp in myDict)
        {
            if (seenValues.Contains(kvp.Value))
            {
                keysToRemove.Add(kvp.Key);
            }
            else
            {
                seenValues.Add(kvp.Value);
            }
        }
        foreach (string key in keysToRemove)
        {
            myDict.Remove(key);
        }
        Console.WriteLine("\nПосле удаления дубликатов:");
        PrintDictionary(myDict);
    }
    void PrintDictionary<Tkey,Tvalue> (Dictionary<Tkey,Tvalue> dict)
    {
        foreach (KeyValuePair<Tkey,Tvalue> kvp in dict)
        {
            Console.WriteLine($"{kvp.Key} : {kvp.Value}");
        }
    }
}
