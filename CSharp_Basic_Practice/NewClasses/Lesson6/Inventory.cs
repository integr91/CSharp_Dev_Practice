namespace CSharp_Basic_Practice.NewClasses.Lesson6;

public class Inventory
{
    private List<object> items = new List<object>();
    private List<IStorable> storage = new List<IStorable>(); // Хранилище
    private int maxStorageCapacity = 10; // Максимальная вместимость хранилища

    // Метод добавления предмета в инвентарь
    public void AddItem(object item)
    {
        items.Add(item);
    }

    // Метод активации предмета по индексу
    public void ActivateItem(int index)
    {
        if (index < 0 || index >= items.Count)
        {
            Console.WriteLine($"Ошибка: индекс {index} выходит за пределы инвентаря (0-{items.Count - 1})");
            return;
        }

        object item = items[index];
        if (item is Weapon weapon)
        {
            weapon.Activate();
            Console.WriteLine($"[{index}] : {weapon.Name} : Weapon");
        }
        else if (item is Armor armor)
        {
            armor.Activate();
            Console.WriteLine($"[{index}] : {armor.Name} : Armor");
        }
        else if (item is Consumable consumable)
        {
            bool success = consumable.Activate();
            Console.WriteLine($"[{index}] : {consumable.Name} : Consumable");
        }
    }

    // Метод для вывода всего инвентаря
    public void DisplayInventory()
    {
        Console.WriteLine("Содержимое инвентаря:");
        for (int i = 0; i < items.Count; i++)
        {
            object item = items[i];
            string itemType = "Unknown";
            string itemName = "Unknown";

            if (item is Weapon w) { itemType = "Weapon"; itemName = w.Name; }
            else if (item is Armor a) { itemType = "Armor"; itemName = a.Name; }
            else if (item is Consumable c) { itemType = "Consumable"; itemName = c.Name; }

            Console.WriteLine($"[{i}] : {itemName} : {itemType}");
        }
        Console.WriteLine();
    }

    // Метод перемещения предмета в хранилище
    public bool MoveToStorage(int index)
    {
        if (index < 0 || index >= items.Count)
        {
            Console.WriteLine($"Ошибка: индекс {index} не существует в инвентаре");
            return false;
        }

        object item = items[index];

        if (item is IStorable storable)
        {
            if (!storable.CanBeStored)
            {
                Console.WriteLine($"Предмет '{(item as dynamic).Name}' нельзя хранить!");
                return false;
            }

            int currentStorageSize = storage.Sum(s => s.StorageSize);
            if (currentStorageSize + storable.StorageSize > maxStorageCapacity)
            {
                Console.WriteLine("Недостаточно места в хранилище!");
                return false;
            }

            storage.Add(storable);
            items.RemoveAt(index);
            Console.WriteLine($"Предмет '{(item as dynamic).Name}' перемещён в хранилище");
            return true;
        }
        else
        {
            Console.WriteLine($"Предмет не поддерживает хранение!");
            return false;
        }
    }

    // Метод извлечения предмета из хранилища
    public bool MoveFromStorage(int storageIndex)
    {
        if (storageIndex < 0 || storageIndex >= storage.Count)
        {
            Console.WriteLine($"Ошибка: индекс {storageIndex} не существует в хранилище");
            return false;
        }

        IStorable item = storage[storageIndex];
        items.Add(item);
        storage.RemoveAt(storageIndex);
        Console.WriteLine($"Предмет '{item.Name}' извлечён из хранилища в инвентарь");
        return true;
    }

    // Метод отображения хранилища
    public void DisplayStorage()
    {
        Console.WriteLine("Содержимое хранилища:");
        for (int i = 0; i < storage.Count; i++)
        {
            IStorable item = storage[i];
            Console.WriteLine($"[{i}] : {item.Name} : StorageSize={item.StorageSize}");
        }
        Console.WriteLine();
    }
    public void ShowInventorySelectionMenu()
    {
        Console.WriteLine("\n=== УПРАВЛЕНИЕ ИНВЕНТАРЁМ ===");
        Console.WriteLine("1. Основной инвентарь");
        Console.WriteLine("2. Хранилище");
        Console.WriteLine("0. Выход");
        Console.Write("Выберите инвентарь: ");
    }

    // Метод для отображения меню действий
    public void ShowActionMenu()
    {
        Console.WriteLine("\n--- Выберите действие:");
        Console.WriteLine("1. Активировать предмет");
        Console.WriteLine("2. Переместить предмет");
        Console.WriteLine("0. Назад");
        Console.Write("Ваш выбор: ");
    }
}