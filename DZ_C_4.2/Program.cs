//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

Console.Write("Введите целое число: ");

int Number = Convert.ToInt32(Console.ReadLine());
int Result = 0;


void Sum( int Number)
{
   while (Number > 0)
   {
     Result += Number % 10; // Последние число из вводного
     Number = Number / 10;   // Перейти к след из числа
   }
 
   Console.Write($"Результат {Result}");
  

}


Sum(Number);
