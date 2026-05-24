public class Person
{
    private string name;
    private int age;
    private Gender gender;
    private Work work;
        
    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Имя не может быть пустым");
            name = value;
        }
    }
    public int Age
    {
        get => age;
        set
        {
            if (value < 0 || value > 150)
                throw new ArgumentException("Возраст должен быть в диапазоне 0–150");
            age = value;
        }
    }
    public Gender Gender
    {
        get => gender;
        set => gender = value;
    }
    public Work Work
    {
        get => work;
        set => work = value;
    }
    public Person(string name, int age, Gender gender, Work work)
    {
        Name = name;
        Age = age;
        Gender = gender;
        Work = work;
    }
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Gender: {Gender}, Work: {Work}";
    }
    public override bool Equals(object obj)
    {
        if (obj is Person other)
        {
            return Name == other.Name &&
                   Age == other.Age &&
                   Gender == other.Gender &&
                   Work.Role == other.Work.Role &&
                   Work.Company == other.Work.Company;
        }
        return false;
    }
    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + (Name?.GetHashCode() ?? 0);
            hash = hash * 23 + Age.GetHashCode();
            hash = hash * 23 + Gender.GetHashCode();
            hash = hash * 23 + Work.Role?.GetHashCode() ?? 0;
            hash = hash * 23 + Work.Company?.GetHashCode() ?? 0;
            return hash;
        }
    }
}