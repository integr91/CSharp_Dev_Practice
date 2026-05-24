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
        ("Задание 6: Которое я сам придумал", Task6),
    };

    // Задание 1: статический класс с методами — сортировка по возрастанию/убыванию, вывод элементов
    // Создайте класс в NewClasses/Lesson5/, вызовите его методы здесь
    private void Task1()
    { 
        {
            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Исходный массив:");
            SortUtils.PrintArray(numbers, "");
            SortUtils.SortAndPrintAscending((int[])numbers.Clone());
            SortUtils.SortAndPrintDescending((int[])numbers.Clone());
        }
    }
    // Задание 2: структура для хранения комплексного числа
    // Создайте структуру ComplexNumber в NewClasses/Lesson5/, создайте экземпляр здесь
    private void Task2()
    {
        ComplexNumber complexNum = new ComplexNumber(3.5, -2.7);
        Console.WriteLine($"Созданное комплексное число: {complexNum}");
    }

    // Задание 3 (*): методы сложения, вычитания и умножения комплексных чисел
    // Добавьте методы в ComplexNumber, продемонстрируйте работу здесь
    private void Task3()
    {
        ComplexNumber num1 = new ComplexNumber(3, 4);
        ComplexNumber num2 = new ComplexNumber(1, -2);
        Console.WriteLine("Демонстрация арифметических операций с комплексными числами:");
        Console.WriteLine($"Число 1: {num1}");
        Console.WriteLine($"Число 2: {num2}");
        Console.WriteLine();
        ComplexNumber sum = num1.Add(num2);
        Console.WriteLine($"Сложение: {num1} + {num2} = {sum}");
        ComplexNumber difference = num1.Subtract(num2);
        Console.WriteLine($"Вычитание: {num1} - {num2} = {difference}");
        ComplexNumber product = num1.Multiply(num2);
        Console.WriteLine($"Умножение: {num1} * {num2} = {product}");
        
    }

    // Задание 4 (*): переопределить операторы +, -, * и метод Equals для ComplexNumber
    // Переопределите операторы в ComplexNumber, проверьте работу здесь
    private void Task4()
    {
        ComplexNumber num1 = new ComplexNumber(3, 4);
        ComplexNumber num2 = new ComplexNumber(1, -2);
        ComplexNumber num3 = new ComplexNumber(3, 4);
        Console.WriteLine("Демонстрация работы переопределённых операторов:");
        Console.WriteLine($"Число 1: {num1}");
        Console.WriteLine($"Число 2: {num2}");
        Console.WriteLine($"Число 3: {num3}");
        Console.WriteLine();
        ComplexNumber sum = num1 + num2;
        Console.WriteLine($"Оператор +: {num1} + {num2} = {sum}");
        ComplexNumber difference = num1 - num2;
        Console.WriteLine($"Оператор -: {num1} - {num2} = {difference}");
        ComplexNumber product = num1 * num2;
        Console.WriteLine($"Оператор *: {num1} × {num2} = {product}");
        Console.WriteLine($"\nПроверка равенства:");
        Console.WriteLine($"{num1} == {num2}: {num1.Equals(num2)}");
        Console.WriteLine($"{num1} == {num3}: {num1.Equals(num3)}");
    }

    // Задание 5 (**): класс Person: поля name/age/gender(enum)/work(struct с role и company)
    // Свойства, переопределить ToString и Equals. Создать список, вывести через PrintData()
    // Создайте класс Person в NewClasses/Lesson5/
    private void Task5()
    {
        Work devWork = new Work("Senior Developer", "TechCorp");
        Work managerWork = new Work("Project Manager", "BusinessSolutions");
        Work designerWork = new Work("UI/UX Designer", "CreativeStudio");
        List<Person> people = new List<Person>
        {
            new Person("Анна Иванова", 28, Gender.Female, devWork),
            new Person("Иван Петров", 35, Gender.Male, managerWork),
            new Person("Мария Сидорова", 24, Gender.Female, designerWork),
            new Person("Алексей Козлов", 42, Gender.Male, new Work("CTO", "InnovationsInc"))
        };
        PrintData(people);
        Console.WriteLine("\nПроверка равенства объектов:");
        Person person1 = people[0];
        Person person2 = new Person("Анна Иванова", 28, Gender.Female, devWork);
        Console.WriteLine($"person1 == person2: {person1.Equals(person2)}");
        Person person3 = people[1];
        Console.WriteLine($"person1 == person3: {person1.Equals(person3)}");
    }
    private void PrintData(List<Person> people)
    {
        Console.WriteLine("Список людей:");
        Console.WriteLine(new string('-', 60));

        for (int i = 0; i < people.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {people[i]}");
        }

        Console.WriteLine(new string('-', 60));
    }

    private void Task6()
    {
        Car myCar = new Car("Toyota", "Camry", 2020, 15000);

        // Выводим информацию
        myCar.GetInfo();

        // Пробуем поехать без запуска двигателя
        myCar.Drive(100);

        // Запускаем двигатель и едем
        myCar.StartEngine();
        myCar.Drive(100);

        // Останавливаем двигатель
        myCar.StopEngine();

        // Снова выводим информацию
        myCar.GetInfo();
    }
}