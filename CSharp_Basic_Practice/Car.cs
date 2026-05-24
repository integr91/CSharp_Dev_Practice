class Car
{
    private string brand;
    private string model;
    private int year;
    private double mileage;
    private bool isRunning;

    public Car(string brand, string model, int year, double mileage)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
        this.mileage = mileage;
        this.isRunning = false;
    }

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public bool IsRunning
    {
        get { return isRunning; }
    }

    public void StartEngine()
    {
        if (!isRunning)
        {
            isRunning = true;
            Console.WriteLine("Двигатель запущен");
        }
    }

    public void StopEngine()
    {
        if (isRunning)
        {
            isRunning = false;
            Console.WriteLine("Двигатель остановлен");
        }
    }

    public void Drive(double distance)
    {
        if (isRunning)
        {
            mileage += distance;
            Console.WriteLine($"Проехали {distance} км");
        }
        else
        {
            Console.WriteLine("Сначала запустите двигатель!");
        }
    }

    public void GetInfo()
    {
        string engineStatus = isRunning ? "Заведён" : "Заглушён";
        Console.WriteLine($"Марка: {brand}");
        Console.WriteLine($"Модель: {model}");
        Console.WriteLine($"Год выпуска: {year}");
        Console.WriteLine($"Пробег: {mileage} км");
        Console.WriteLine($"Состояние двигателя: {engineStatus}");
    }
}