Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > a && b > c) max = b; // Говорилось что после условия ; не нужна а тут почему?
if (c > a && c > b) max = c;
Console.WriteLine($"Максимальное число найдено и равно {max}");