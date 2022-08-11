Console.WriteLine("Введите целое число:");
int a = Convert.ToInt32(Console.ReadLine());
if(a >= 100)
{string b = a.ToString();
Console.Write($"{b[2]}");
}
else
{
    Console.WriteLine("Неверный ввод или ошибка");
}