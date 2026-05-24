namespace CSharp_Basic_Practice.NewClasses.Lesson6;

public class Consumable : IStorable
{
    public string Name { get; set; }
    public int StorageSize => 1; // Занимает 1 единицу места
    public bool CanBeStored => false; // Нельзя хранить (расходуется при использовании)

    public Consumable(string name)
    {
        Name = name;
    }

    public virtual bool Activate()
    {
        Console.WriteLine($"Расходуемый предмет '{Name}' использован!");
        return true;
    }
}