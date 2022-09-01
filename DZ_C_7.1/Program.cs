double[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    double[,] array = new double[rowCount, columnCount]; // создание двухмерного массива
    for (int row = 0; row < rowCount; row++) // по строкам массива
    {
        for (int column = 0; column < columnCount; column++) // по столбцам
        {
            array[row, column] = new Random().NextDouble() * new Random().Next(min, max);
            array[row, column] = Math.Round(array[row, column], 2);
        }
    }
    return array;
}

void PrintMatrix(double[,] array)
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

double[,] matrix = CreateMatrix(5, 3, 0, 99);
PrintMatrix(matrix);

