Console.WriteLine("Введите длинну массива:"); // размер массива

int length = Convert.ToInt32(Console.ReadLine()); // инпут в инт
int[] arr = new int[length]; // создание массива 
int[] CreateArr(int length) // функция заполнения массива
{

    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(-99, 100);
    }
    return arr;
}

void PrintArr(int[] arr) // функция вывода массива чтобы понимать что программа работает
{
    Console.Write(String.Join(",", arr));
}

void SumOdd(int[] arr) // нахождение суммы нечетных элементов и вывод 
{
    int res = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0)

            res += arr[i];
    }

    Console.WriteLine($" Сумма нечётных чисел массива {res}");
}

CreateArr(length);
PrintArr(arr);
SumOdd(arr);