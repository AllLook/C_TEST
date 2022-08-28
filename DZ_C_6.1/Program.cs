Console.WriteLine("Введите количество чисел "); // размер массива
int M   = Convert.ToInt32(Console.ReadLine()); // инпут в инт
int[] arr = new int[M]; // создание массива 
void CreateArr(int M) // функция заполнения массива
{
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine("Введите число ");
        int num = Convert.ToInt32(Console.ReadLine());
        arr[i] = num;
    }
    Console.Write(String.Join(",", arr));
}


void Big(int[] arr) 
{
    int res = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) res+= 1;
    }

    Console.WriteLine($" Чисел больше 0 в массиве {res}");
}

CreateArr(M);
Big(arr);
