// Урок 5: Классы и структуры
// Дополнительные классы создавать в NewClasses/Lesson5/

public class Lesson5 : BaseLesson
{
    protected override (string name, Action task)[] GetTasks() => new (string, Action)[]
    {
        ("Задание 1: Статический класс — сортировка и вывод", Task1),
        ("Задание 2: Структура ComplexNumber", Task2),
        ("Задание 3 (*): Арифметика комплексных чисел", Task3),
        ("Задание 4 (*): Перегрузка операторов +, -, * и Equals", Task4),
        ("Задание 5 (**): Класс Person", Task5),
    };

    // Задание 1: статический класс с методами — сортировка по возрастанию/убыванию, вывод элементов
    // Создайте класс в NewClasses/Lesson5/, вызовите его методы здесь
    private void Task1()
    {

    }

    // Задание 2: структура для хранения комплексного числа
    // Создайте структуру ComplexNumber в NewClasses/Lesson5/, создайте экземпляр здесь
    private void Task2()
    {

    }

    // Задание 3 (*): методы сложения, вычитания и умножения комплексных чисел
    // Добавьте методы в ComplexNumber, продемонстрируйте работу здесь
    private void Task3()
    {

    }

    // Задание 4 (*): переопределить операторы +, -, * и метод Equals для ComplexNumber
    // Переопределите операторы в ComplexNumber, проверьте работу здесь
    private void Task4()
    {

    }

    // Задание 5 (**): класс Person: поля name/age/gender(enum)/work(struct с role и company)
    // Свойства, переопределить ToString и Equals. Создать список, вывести через PrintData()
    // Создайте класс Person в NewClasses/Lesson5/
    private void Task5()
    {

    }
}
