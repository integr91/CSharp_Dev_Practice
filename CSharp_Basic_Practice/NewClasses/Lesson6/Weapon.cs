namespace CSharp_Basic_Practice.NewClasses.Lesson6;

public class Weapon : IStorable
{
    public string Name { get; set; }
    public int StorageSize => 2; // Занимает 2 единицы места
    public bool CanBeStored => true; // Можно хранить


    public Weapon(string name)
    {
        Name = name;
    }

    public virtual void Activate()
    {
        Console.WriteLine($"Оружие '{Name}' активировано!");
    }
}