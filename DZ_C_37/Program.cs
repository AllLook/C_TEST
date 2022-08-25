Console.WriteLine("Введите длинну массива:"); // размер массива

int length = Convert.ToInt32(Console.ReadLine()); // инпут в инт
int[] arr = new int[length]; // создание массива 
int[] CreateArr(int length) // функция заполнения массива
{

    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}

void PrintArr(int[] arr) // функция вывода массива чтобы понимать что программа работает
{
    Console.Write(String.Join(",", arr));
}

void WorkRec(int[] arr)
{
    int len;
    if (arr.Length % 2 == 0) len = arr.Length / 2;// новая длинна масива меньше в двое потому что пары перемножаться
    else len = arr.Length / 2 + 1;
    int[] array = new int[len]; // новый массив 
    for (int i = 0; i < arr.Length / 2; i++)
    {
        array[i] = arr[i] * arr[arr.Length - 1 - i]; // текущий индекс с шагом -1 то есть текущий с конца
    }
    if (arr.Length % 2 != 0) array[arr.Length / 2] = arr[arr.Length / 2]; // что значит в значение деленое на 2 присвоить деленое на 2? Ведь если не четный на 2 не делиться
  Console.Write($" Новый массив {String.Join(" " , array)}");
  
}

CreateArr(length);
PrintArr(arr);
WorkRec(arr);
