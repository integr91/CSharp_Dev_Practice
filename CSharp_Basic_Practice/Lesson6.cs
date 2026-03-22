// Урок 6: Абстракция и пространства имён
// Все классы создавать в NewClasses/Lesson6/ в отдельном пространстве имён

public class Lesson6 : BaseLesson
{
    protected override (string name, Action task)[] GetTasks() => new (string, Action)[]
    {
        ("Задание 2 (*): Weapon, Armor, Consumable с методом Activate()", Task2),
        ("Задание 3 (*): Класс Inventory", Task3),
        ("Задание 4 (***): Интерфейс IStorable и хранилище", Task4),
        ("Задание 5 (**): Интерактивное управление инвентарём", Task5),
    };

    // Задание 2 (*): классы Weapon, Armor, Consumable с методом Activate()
    // У Consumable метод переопределён: выводит сообщение об использовании и возвращает true
    // Создайте классы в NewClasses/Lesson6/, вызовите Activate() на каждом
    private void Task2()
    {

    }

    // Задание 3 (*): класс Inventory со списком предметов; активация по индексу
    // Формат вывода: "[индекс] : {название} : {тип}"
    // Добавьте Inventory в NewClasses/Lesson6/
    private void Task3()
    {

    }

    // Задание 4 (***): интерфейс IStorable со свойствами StorageSize и CanBeStored
    // Реализовать в классах предметов; в Inventory добавить storage и методы MoveToStorage/MoveFromStorage
    private void Task4()
    {

    }

    // Задание 5 (**): интерактивное управление инвентарём
    // Выбор инвентаря (основной / хранилище), выбор действия (активировать / переместить)
    private void Task5()
    {

    }
}
