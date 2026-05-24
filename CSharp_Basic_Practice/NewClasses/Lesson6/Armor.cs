namespace CSharp_Basic_Practice.NewClasses.Lesson6;

public class Armor : IStorable
{
    public string Name { get; set; }
    public int StorageSize => 3; // Занимает 3 единицы места
    public bool CanBeStored => true; // Можно хранить


    public Armor(string name)
    {
        Name = name;
    }

    public virtual void Activate()
    {
        Console.WriteLine($"Броня '{Name}' активирована!");
    }
}