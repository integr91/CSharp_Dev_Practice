public static class SortUtils
{
    public static void SortAndPrintAscending(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine("Ошибка: массив равен null");
            return;
        }
        Array.Sort(array);
        PrintArray(array, "Отсортированный массив (по возрастанию):");
    }
    public static void SortAndPrintDescending(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine("Ошибка: массив равен null");
            return;
        }
        Array.Sort(array);
        Array.Reverse(array);
        PrintArray(array, "Отсортированный массив (по убыванию):");
    }
    public static void PrintArray(int[] array, string message)
    {
        Console.WriteLine(message);
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}