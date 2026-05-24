namespace CSharp_Basic_Practice.NewClasses.Lesson6;

public interface IStorable
{
    int StorageSize { get; }
    bool CanBeStored { get; }
    string Name { get; }
}