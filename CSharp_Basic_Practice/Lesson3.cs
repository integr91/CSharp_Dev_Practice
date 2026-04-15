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

    }

    // Задание 2: отсортировать массив из N целых чисел по убыванию и по возрастанию
    private void SortArray()
    {

    }

    // Задание 3 (*): найти минимум, максимум и среднее значение в списке
    // Формат вывода: "Индекс : Значение"
    private void FindMinMaxAvg()
    {

    }

    // Задание 4: создать словарь номер месяца (1–12) → название месяца; вывести
    private void MonthDictionary()
    {

    }

    // Задание 5: объединить два Dictionary<string, int>
    // При совпадении ключей — взять большее из двух значений
    private void MergeDictionaries()
    {

    }

    // Задание 6: удалить из Dictionary<string, int> элементы с повторяющимися значениями
    private void RemoveDuplicateValues()
    {

    }
}
