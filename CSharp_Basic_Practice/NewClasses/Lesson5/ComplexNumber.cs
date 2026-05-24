public struct ComplexNumber
{
    public readonly double Real;
    public readonly double Imaginary;

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public override string ToString()
    {
        if (Imaginary == 0)
            return Real.ToString();
        if (Real == 0)
            return $"{Imaginary}";
        if (Imaginary < 0)
            return $"{Real}{Imaginary}";
        return $"{Real}+{Imaginary}";
    }

    // Метод сложения
    public ComplexNumber Add(ComplexNumber other)
    {
        return new ComplexNumber(Real + other.Real, Imaginary + other.Imaginary);
    }

    // Метод вычитания
    public ComplexNumber Subtract(ComplexNumber other)
    {
        return new ComplexNumber(Real - other.Real, Imaginary - other.Imaginary);
    }

    // Метод умножения
    public ComplexNumber Multiply(ComplexNumber other)
    {
        double newReal = Real * other.Real - Imaginary * other.Imaginary;
        double newImaginary = Real * other.Imaginary + Imaginary * other.Real;
        return new ComplexNumber(newReal, newImaginary);
    }

    // Переопределение оператора сложения (+)
    public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
    {
        return a.Add(b);
    }

    // Переопределение оператора вычитания (-)
    public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
    {
        return a.Subtract(b);
    }

    // Переопределение оператора умножения (*)
    public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
    {
        return a.Multiply(b);
    }

    // Переопределение метода Equals для сравнения комплексных чисел
    public override bool Equals(object obj)
    {
        if (obj is ComplexNumber other)
        {
            // Используем сравнение с учётом погрешности для double
            const double epsilon = 1e-10;
            return Math.Abs(Real - other.Real) < epsilon &&
                   Math.Abs(Imaginary - other.Imaginary) < epsilon;
        }
        return false;
    }

    // Переопределение GetHashCode для корректной работы с коллекциями
    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + Real.GetHashCode();
            hash = hash * 23 + Imaginary.GetHashCode();
            return hash;
        }
    }
}