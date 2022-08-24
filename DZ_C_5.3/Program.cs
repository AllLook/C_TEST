


Console.WriteLine("Введите длинну массива:"); // размер массива

int length = Convert.ToInt32(Console.ReadLine()); // инпут в инт
double[] arr = new double[length]; // создание массива 
double[] CreateArr(int length) // функция заполнения массива
{

    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(0, 100); // во всех задачах задал двухзначные числа чтобы было проще,
        // если задать массив с отрицательными значениями(например от -99,100 в рандом) то если min отрицательное минус на минус дает плюс и получается сумма положительных вместо разницы как это можно исправить?
    }
    return arr;
}

void PrintArr(double[] arr) // функция вывода массива чтобы понимать что программа работает
{
    Console.Write(String.Join(",", arr));
}

void Defference(double[] arr) // нахождение суммы нечетных элементов и вывод 
{
    double res = 0;
    double min = arr[0];
    double max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <= min) min = arr[i];

        else if (arr[i] >= max) max = arr[i];
    }


    Console.WriteLine($" Разница между min и max{res = max - min}");
}


CreateArr(length);
PrintArr(arr);
Defference(arr);