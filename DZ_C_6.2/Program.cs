
Console.WriteLine("Введите значение b1: "); 
double b1   = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Введите значение k1: "); 
double k1   = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Введите значение b2:"); 
double b2   = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2:"); 
double k2   = Convert.ToDouble(Console.ReadLine()); 

void Dot(double b1, double k1, double b2, double k2)
{
    double x = (-b2 + b1)/(-k1+k2);
    double y = k2 * x + b2;
    Console.Write($"Точка пересечения X:{x} , Y:{y}");
}

Dot(b1, k1, b2, k2);