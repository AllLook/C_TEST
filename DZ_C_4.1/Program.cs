          // Так проще, решение в одну строку цикл здесь не к чему по моему))

//Console.WriteLine("Введите число:"); 
//double A = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите степень для числа:"); 
//double B = Convert.ToInt32(Console.ReadLine());
//void Degree(double A,double B)
//{
//double Result =  Math.Pow(A, B); 
//Console.Write($"Результат {Result}");
//}
//Degree(A,B);



Console.WriteLine("Введите число:"); 
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень для числа:"); 
int  B = Convert.ToInt32(Console.ReadLine());
async void Degree(int A,int B)
{
  int Res = 1; // на 0 умножать нельзя всегда 0 будет
  
 for(int i = 1 ; i <= B; i ++ ) // начиная с 1 и до 5 вкл. 
      {
        Res *= A; // первый раз само число,прошлый результат умножается на исходное число и перезаписывается заданное кол во раз
        
      } 

    Console.WriteLine($"Результат {Res}");
}

Degree(A,B);