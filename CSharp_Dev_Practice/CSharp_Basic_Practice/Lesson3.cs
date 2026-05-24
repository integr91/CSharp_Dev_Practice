// Урок 3: Массивы и коллекции

public class Lesson3 : BaseLesson
{
    protected override (string name, Action task)[] GetTasks() => new (string, Action)[]
    {
        ("Задание 2: Вывести размер и содержимое списка", PrintList),
        ("Задание 3: Сортировка массива по убыванию и возрастанию", SortArray),
        ("Задание 4 (*): Минимум, максимум и среднее значение", FindMinMaxAvg),
        ("Задание 5: Словарь месяцев (1–12)", MonthDictionary),
        ("Задание 6: Объединение двух словарей", MergeDictionaries),
        ("Задание 7: Удаление дублирующихся значений из словаря", RemoveDuplicateValues),
    };

    // Задание 2: вывести размер списка и его содержимое
    private void PrintList()
    {

    }

    // Задание 3: отсортировать массив из N целых чисел по убыванию и по возрастанию
    private void SortArray()
    {

    }

    // Задание 4 (*): найти минимум, максимум и среднее значение в списке
    // Формат вывода: "Индекс : Значение"
    private void FindMinMaxAvg()
    {

    }

    // Задание 5: создать словарь номер месяца (1–12) → название месяца; вывести
    private void MonthDictionary()
    {

    }

    // Задание 6: объединить два Dictionary<string, int>
    // При совпадении ключей — взять большее из двух значений
    private void MergeDictionaries()
    {

    }

    // Задание 7: удалить из Dictionary<string, int> элементы с повторяющимися значениями
    private void RemoveDuplicateValues()
    {

    }
}
