

 double Distance(double x1, double y1, double z1,double x2, double y2, double z2)
{
    double segment = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2 ) + Math.Pow(z2-z1,2));
    return segment;
    Console.Write($"{Distance} ");
}


Console.WriteLine("Введите первую координату для точки A:");
double a1 = Convert.ToDouble(Console.ReadLine());
double x1 = a1;
Console.WriteLine("Введите вторую координату для точки A:");
double a2 = Convert.ToDouble(Console.ReadLine());
double y1 = a2;
Console.WriteLine("Введите третью координату для точки A:");
double a3 = Convert.ToDouble(Console.ReadLine());
double z1 = a3;

Console.WriteLine("Введите первую координату для точки B:");
double b1 = Convert.ToDouble(Console.ReadLine());
double x2 = b1;
Console.WriteLine("Введите вторую координату для точки B:");
double b2 = Convert.ToDouble(Console.ReadLine());
double y2 = b2;
Console.WriteLine("Введите третью координату для точки B:");
double b3 = Convert.ToDouble(Console.ReadLine());
double z2 = b3;
double dist = Distance(x1,y1,z1,x2,y2,z2);
Console.WriteLine($"Результат {Math.Round(dist,2)}");