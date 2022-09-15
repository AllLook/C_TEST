
int[,] CreateMatrix1(int rowCount, int columnCount, int min, int max)
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

int[,] CreateMatrix2(int rowCount, int columnCount, int min, int max)
{
    int[,] arr = new int[rowCount, columnCount]; // создание двухмерного массива
    for (int row = 0; row < rowCount; row++) // по строкам массива
    {
        for (int column = 0; column < columnCount; column++) // по столбцам
        {
            arr[row, column] = new Random().Next(min, max);

        }
    }
    return arr;
}


void PrintMatrix(int[,] array) // печать массива
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row, column]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



int[,] Work(int[,] array, int[,] arr)
{
    int rows1 = array.GetLength(0);
    int colums1 = array.GetLength(1);
    int rows2 = arr.GetLength(0);
    int colums2 = arr.GetLength(1);
    int[,] product = new int[rows1, colums2]; // новый массив для результата
    if (colums1 == rows2) // чтобы матрицы были соразмерны
        for (int row1 = 0; row1 < rows1; row1++) // по строкам первого
        {
            for (int col2 = 0; col2 < colums2; col2++) // по столбцам второго
            {
                for (int col1 = 0; col1 < colums1; col1++) // по столбцам первого

                    product[row1, col2] += array[row1, col1] * arr[col1, col2]; // такая формула
            }
        }
    return product;
}

int[,] matrix1 = CreateMatrix1(2, 2, 0, 10); // первый массив 
int[,] matrix2 = CreateMatrix2(2, 2, 0, 10); // второй массив
PrintMatrix(matrix1);
PrintMatrix(matrix2); // вывод созданных массивов
int[,] matrix3 = Work(matrix1, matrix2); // новый массив результат
PrintMatrix(matrix3); // вывод результата 