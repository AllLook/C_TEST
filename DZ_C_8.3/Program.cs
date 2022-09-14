
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


void PrintMatrix1(int[,] array)
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

void PrintMatrix2(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{arr[row, column]}\t");
        }
        Console.WriteLine();
    }
}


int[,] Work(int[,] array, int[,] arr)
{

    int rows1 = array.GetLength(0);
    int colums1 = array.GetLength(1);
    int rows2 = arr.GetLength(0);
    int colums2 = arr.GetLength(1);
    int[,] product = new int[rows1, colums2]; // новый массив для результата
    if (colums1 == rows2) // условие что кол во столбцов первого массива равно кол ву строк второго(чтобы матрицы были схожи)
    {

        for (int row1 = 0; row1 < rows1; row1++) // по строкам первого массива
        {
            for (int column1 = 0; column1 < colums1; column1++) // по столбцам первого массива
            {
                for (int column2 = 0; column2 < colums2; column2++) // по столбцам второго массива
                {
                    for (int row2 = 0; row2 < rows2; row2++) // по строкам второго массива
                    {
                        for (int row3 = 0; row3 < rows1; rows1++) // цикл для нового массива 
                        {
                            for (int column3 = 0; column3 < colums2; column3++)
                            {

                                product[row3, column3] += array[row1, column1] * arr[column2, row2]; // Произведение в текущий индекс

                            }

                        }
                    }
                }

            }
        }
    }

    return product;
}

int[,] matrix1 = CreateMatrix1(3, 3, 0, 10); // первый массив 
int[,] matrix2 = CreateMatrix2(3, 3, 0, 10); // второй массив
PrintMatrix1(matrix1);
PrintMatrix2(matrix2); // вывод созданных массивов
int[,] matrix3 = Work(matrix1,matrix2); // новый массив результат
PrintMatrix2(matrix3); // вывод результата