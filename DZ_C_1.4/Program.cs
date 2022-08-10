
Console.WriteLine("Введите целое положительное число больше 1");
int a = Convert.ToInt32(Console.ReadLine());
int i = 2;
while(i <= a)
{
  Console.Write($"{i} ");
  i = i + 2; // Переназначает i даже где бы оно не было(вне цикла)?
}



