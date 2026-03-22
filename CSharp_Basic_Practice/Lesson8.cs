// Урок 8: Делегаты и события

public class Lesson8 : BaseLesson
{
    protected override (string name, Action task)[] GetTasks() => new (string, Action)[]
    {
        ("Задание 2: Класс Timer с событиями Tick и Finished", Task2),
        ("Задание 3: Фильтрация списка через Predicate", Task3),
        ("Задание 4 (**): LogMessage и Logger", Task4),
        ("Задание 5: ConsoleLogger с цветовой дифференциацией", Task5),
    };

    // Задание 2: класс Timer с событиями Tick и Finished
    // Методы: Start(int seconds), OnTick(), OnFinished()
    // Подпишитесь на события, запустите таймер на 5 секунд
    private void Task2()
    {

    }

    // Задание 3: List<int> от 1 до 20; предикаты IsEven, IsOdd, IsGreaterThanTen
    // Отфильтровать список тремя способами через FilterNumbers
    private void Task3()
    {
        var numbers = Enumerable.Range(1, 20).ToList();
        FilterNumbers(numbers, IsEven);
        FilterNumbers(numbers, IsOdd);
        FilterNumbers(numbers, IsGreaterThanTen);
    }

    private bool IsEven(int n)
    {
        return default;
    }

    private bool IsOdd(int n)
    {
        return default;
    }

    private bool IsGreaterThanTen(int n)
    {
        return default;
    }

    // Метод для фильтрации списка по предикату
    private List<int> FilterNumbers(List<int> numbers, Predicate<int> predicate)
    {
        return new List<int>();
    }

    // Задание 4 (**): структура LogMessage (Time, Level, Message, Source)
    // Класс Logger с событием Action<LogMessage> и методами Info(), Warning(), Error()
    // Создайте структуру и класс, подпишитесь на событие, протестируйте все уровни
    private void Task4()
    {

    }

    // Задание 5: ConsoleLogger с цветовой дифференциацией по уровню логирования
    // Формат: "[Время] [Уровень]: Сообщение"
    // Подпишите ConsoleLogger на Logger из Task4
    private void Task5()
    {

    }
}
