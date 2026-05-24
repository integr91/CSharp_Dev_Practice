// Урок 6: Абстракция и пространства имён
// Все классы создавать в NewClasses/Lesson6/ в отдельном пространстве имён

using CSharp_Basic_Practice.NewClasses.Lesson6;

public class Lesson6 : BaseLesson
{
    protected override (string name, Action task)[] GetTasks() => new (string, Action)[]
    {
        ("Задание 1 (*): Weapon, Armor, Consumable с методом Activate()", Task1),
        ("Задание 2 (*): Класс Inventory", Task2),
        ("Задание 3 (***): Интерфейс IStorable и хранилище", Task3),
        ("Задание 4 (**): Интерактивное управление инвентарём", Task4),
    };

    // Задание 1 (*): классы Weapon, Armor, Consumable с методом Activate()
    // У Consumable метод переопределён: выводит сообщение об использовании и возвращает true
    // Создайте классы в NewClasses/Lesson6/, вызовите Activate() на каждом
    private void Task1()
    {
        Weapon sword = new Weapon("Меч воина");
        Armor shield = new Armor("Стальной щит");
        Consumable potion = new Consumable("Зелье здоровья");

        sword.Activate();
        shield.Activate();

        bool isUsed = potion.Activate();
        Console.WriteLine($"Зелье использовано успешно: {isUsed}");
    }

    // Задание 2 (*): класс Inventory со списком предметов; активация по индексу
    // Формат вывода: "[индекс] : {название} : {тип}"
    // Добавьте Inventory в NewClasses/Lesson6/
    private void Task2()
    {
        Inventory inventory = new Inventory();

        inventory.AddItem(new Weapon("Огненный меч"));
        inventory.AddItem(new Armor("Магический щит"));
        inventory.AddItem(new Consumable("Зелье маны"));
        inventory.AddItem(new Weapon("Лук охотника"));

        inventory.DisplayInventory();

        Console.WriteLine("Активация предметов:");
        inventory.ActivateItem(0);
        inventory.ActivateItem(2);
        inventory.ActivateItem(5);
    }

    // Задание 3 (***): интерфейс IStorable со свойствами StorageSize и CanBeStored
    // Реализовать в классах предметов; в Inventory добавить storage и методы MoveToStorage/MoveFromStorage
    private void Task3()
    {
        // Создаём инвентарь
        Inventory inventory = new Inventory();

        // Добавляем предметы разных типов
        inventory.AddItem(new Weapon("Огненный меч"));
        inventory.AddItem(new Armor("Магический щит"));
        inventory.AddItem(new Consumable("Зелье маны"));
        inventory.AddItem(new Weapon("Лук охотника"));

        // Показываем начальный инвентарь
        inventory.DisplayInventory();

        // Перемещаем предметы в хранилище
        Console.WriteLine("Перемещение предметов в хранилище:");
        inventory.MoveToStorage(0); // Огненный меч
        inventory.MoveToStorage(1); // Магический щит
        inventory.MoveToStorage(2); // Зелье маны (не переместится)

        // Показываем обновлённый инвентарь и хранилище
        inventory.DisplayInventory();
        inventory.DisplayStorage();

        // Извлекаем предмет из хранилища
        Console.WriteLine("Извлечение предмета из хранилища:");
        inventory.MoveFromStorage(0);

        // Финальное состояние
        inventory.DisplayInventory();
        inventory.DisplayStorage();
    }

    // Задание 4 (**): интерактивное управление инвентарём
    // Выбор инвентаря (основной / хранилище), выбор действия (активировать / переместить)
    private void Task4()
    {
        // Создаём инвентарь и наполняем его предметами
        Inventory inventory = new Inventory();

        inventory.AddItem(new Weapon("Огненный меч"));
        inventory.AddItem(new Armor("Магический щит"));
        inventory.AddItem(new Consumable("Зелье маны"));
        inventory.AddItem(new Weapon("Лук охотника"));

        bool isRunning = true;

        while (isRunning)
        {
            // Показываем меню выбора инвентаря
            inventory.ShowInventorySelectionMenu();
            string inventoryChoice = Console.ReadLine();

            switch (inventoryChoice)
            {
                case "0":
                    isRunning = false;
                    Console.WriteLine("Выход из программы.");
                    break;

                case "1":
                    // Основной инвентарь
                    ProcessInventory(inventory, "основной");
                    break;

                case "2":
                    // Хранилище
                    ProcessStorage(inventory);
                    break;

                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
    private void ProcessInventory(Inventory inventory, string inventoryType)
{
    Console.Clear();
    Console.WriteLine($"=== {inventoryType.ToUpper()} ИНВЕНТАРЬ ===");
    inventory.DisplayInventory();

    inventory.ShowActionMenu();
    string actionChoice = Console.ReadLine();

    switch (actionChoice)
    {
        case "1":
            // Активация предмета
            Console.Write("Введите индекс предмета для активации: ");
            if (int.TryParse(Console.ReadLine(), out int activateIndex))
            {
                inventory.ActivateItem(activateIndex);
            }
            else
            {
                Console.WriteLine("Некорректный индекс.");
            }
            break;

        case "2":
            // Перемещение в хранилище
            Console.Write("Введите индекс предмета для перемещения в хранилище: ");
            if (int.TryParse(Console.ReadLine(), out int moveIndex))
            {
                inventory.MoveToStorage(moveIndex);
            }
            else
            {
                Console.WriteLine("Некорректный индекс.");
            }
            break;

        case "0":
            Console.Clear();
            break;

        default:
            Console.WriteLine("Неверный выбор действия.");
            break;
    }
}

// Вспомогательный метод для работы с хранилищем
private void ProcessStorage(Inventory inventory)
{
    Console.Clear();
    Console.WriteLine("=== ХРАНИЛИЩЕ ===");
    inventory.DisplayStorage();

    Console.WriteLine("--- Выберите действие:");
    Console.WriteLine("1. Извлечь предмет в инвентарь");
    Console.WriteLine("0. Назад");
    Console.Write("Ваш выбор: ");

    string actionChoice = Console.ReadLine();

    switch (actionChoice)
    {
        case "1":
            Console.Write("Введите индекс предмета для извлечения: ");
            if (int.TryParse(Console.ReadLine(), out int extractIndex))
            {
                inventory.MoveFromStorage(extractIndex);
            }
            else
            {
                Console.WriteLine("Некорректный индекс.");
            }
            break;

        case "0":
            Console.Clear();
            break;

        default:
            Console.WriteLine("Неверный выбор действия.");
            break;
    }
}
}

