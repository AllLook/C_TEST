Console.WriteLine("Введите целое трехзначное число:");
int a = Convert.ToInt32(Console.ReadLine());
if(a >= 100 &&  a < 1000)
{int b = (a % 100) / 10;
Console.Write($"{b}");
}
else
{
    Console.WriteLine("Неверный ввод или ошибка");
}
