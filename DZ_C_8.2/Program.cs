/* Console.WriteLine("Количество строк ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов");
int columnCount = Convert.ToInt32(Console.ReadLine()); */
int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount]; // создание двухмерного массива
    for (int row = 0; row < rowCount; row++) // по строкам массива
    {
        for (int column = 0; column < columnCount; column++) // по столбцам
        {
            array[row, column] = new Random().Next(min, max);

        }
    }
    return array;
}
void PrintMatrix(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row, column]}\t");
        }
        Console.WriteLine();
    }
}

int[] Sum(int[,] array)
{  //int res = 0;
    int rows = array.GetLength(0); // переменная с кол вом строк
    int colums = array.GetLength(1);// переменная с кол вом столбцов
    int[] arr = new int[rows]; // новый массив размером с кол во  строк
    for (int row = 0; row < rows; row++) //цикл по строкам 
    {
        for (int column = 0; column < colums; column++)// цикл по столбцам 
        {


            arr[row] += array[row, column]; // значения накапливаются в текущий индекс нового массива 

        }
        /*  Console.WriteLine();
         Console.Write(arr[row]); */
    }
    return arr;

}
void PrintAr(int[] arr)
{
    //Console.Write(String.Join(" " , arr));
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]}");
    }
}

void Sort(int[] arr)
{
    int number = 0;
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        //int min = arr[i];
        if (arr[i] < min)
        {
            arr[i] = min;
            number += 1;
        }


        /*   Console.WriteLine();
          Console.Write($"{min}");  */
    }
    Console.WriteLine();
    Console.Write($"Строка с наименьшим значением {number}"); // вывод для пользователя
}

int[,] matrix = CreateMatrix(3, 3, 0, 10);
PrintMatrix(matrix);
Sum(matrix);
int[] maximum = Sum(matrix);
PrintAr(maximum);
Sort(maximum);
//PrintMatrix(matrix);