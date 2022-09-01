// сначала создаем массив в котором будем искать

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



int Search(int[,] array, int rowPosition, int columnPosition)

{

    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            if (row == rowPosition && column == columnPosition)
                return array[row, column]; // ВОЗВРАЩАЕМ ЗНАЧ ЕСЛИ ЭЛЕМЕНТ ЕСТЬ


        }
    }
    return 0; //ТАК И НЕ ПРИДУМАЛ КАКОЙ УКАЗАТЕЛЬ КРОМЕ 0 ВЕРНУТЬ ЧТО ЭЛЕМНТА НЕТ
}
int res = 0;
void PrintSearch()
{
    Console.WriteLine($"Элемент с такими позициями  {res}");
}



int[,] matrix = CreateMatrix(3, 3, 0, 10);
//Console.WriteLine(String.Join(",", matrix)); Почему не выводит так?
PrintMatrix(matrix);
res = Search(matrix, 0, 11);
PrintSearch();
