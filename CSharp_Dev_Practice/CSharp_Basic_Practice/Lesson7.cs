// Урок 7: Основные возможности System

public class Lesson7 : BaseLesson
{
    protected override (string name, Action task)[] GetTasks() => new (string, Action)[]
    {
        ("Задание 1: Класс Book — ToString, Equals, GetHashCode", Task1),
        ("Задание 2: StringBuilder vs string — сравнение производительности", CompareStringBuilders),
        ("Задание 3: Текущее время в формате dd.MM.yyyy HH:mm", PrintCurrentTime),
        ("Задание 4: Конвертер секунд в hh:mm:ss", Task4),
        ("Задание 5: Симуляция броска кубиков", Task5),
        ("Задание 6 (**): Бросок кубиков с заданными вероятностями", Task6),
    };

    // Задание 1: создать класс Book с полями Title и Author
    // Переопределить ToString(), Equals(), GetHashCode()
    // Создайте экземпляры и проверьте переопределённые методы
    private void Task1()
    {

    }

    // Задание 2: сложить 50 000 строк "Hello" через string и через StringBuilder
    // Вывести время выполнения каждого способа
    private void CompareStringBuilders()
    {

    }

    // Задание 3: вывести текущее время в формате dd.MM.yyyy HH:mm
    private void PrintCurrentTime()
    {

    }

    // Задание 4: принять секунды, вывести в формате hh:mm:ss
    private void ConvertSeconds(int totalSeconds)
    {

    }

    private void Task4()
    {
        ConvertSeconds(3723);
    }

    // Задание 5: симуляция броска N кубиков с M гранями
    // Вывести значение каждого кубика и итоговую сумму
    private void RollDice(int diceCount, int faces)
    {

    }

    private void Task5()
    {
        RollDice(3, 6);
    }

    // Задание 6 (**): перегрузка RollDice с Dictionary<int, float> для задания вероятностей граней
    // Проверка: сумма всех вероятностей не может быть >= 1
    private void RollDice(int diceCount, Dictionary<int, float> probabilities)
    {

    }

    private void Task6()
    {
        // TODO: создайте словарь вероятностей и вызовите RollDice с ним
    }
}
