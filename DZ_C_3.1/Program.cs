Console.WriteLine("Введите пятизначное число: "); 
                                                  // Принимаем INТ чтобы число было целым
int a = Convert.ToInt32(Console.ReadLine()); 
string b = a.ToString(); // преобразум int в string чтобы разобрать по индексам
 void mirror(string b) // обьявляем функцию
{
    
    string []c = new string[] {$"{b[0]}, ${b[1]}, ${b[2]}, ${b[3]}, ${b[4]}" };
                                                              // два массива с обратным порядком элементов
    string []d = new string[] {$"{b[4]}, ${b[3]}, ${b[2]}, ${b[1]}, ${b[0]}" };
    if(c.SequenceEqual(d)) // сравниваем
    
    Console.Write("Это полиндром");
    else 
    Console.Write("Это разные вещи");
   

}
if(b.Length == 5)
    {
      mirror(b);
    }
else
    {
        Console.Write("Введите пятизначное число");
    }

