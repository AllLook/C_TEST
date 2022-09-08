Console.WriteLine("Количество строк ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов");
int columnCount = Convert.ToInt32(Console.ReadLine());
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

//int i = 0;

//double[] arr = new double[columnCount]; 


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

void Average(int[,] array)
{   
    int colums = array.GetLength(1);// переменная с кол вом столбцов
    int rows = array.GetLength(0); // переменная с кол вом строк 
    double [] arr = new double[colums]; // новый массив размером с кол во  столбцов

    for (int column = 0; column < colums; column++)// цикл по столбцам 
    {   
        for (int row = 0; row < rows; row++) //цикл по строкам 
        {

            arr[column] += array[row, column]; // индекс столбца 
            
        }

        Console.WriteLine($"{Math.Round(arr[column]/ rows , 2)}");
    }
    //Console.WriteLine($"{arr[i] / rowCount}");
}
int[,] matrix = CreateMatrix(rowCount, columnCount, 0, 10);
PrintMatrix(matrix);
Average(matrix);
