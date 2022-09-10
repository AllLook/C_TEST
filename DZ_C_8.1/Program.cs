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

int[,] Sorting(int[,] array)
{   
   //int rows = array.GetLength(0); // переменная с кол вом строк
    //int colums = array.GetLength(1);// переменная с кол вом столбцов
    //int [,] arr = new int[rows,colums]; // новый массив размером с кол во  столбцов
    for (int row=0; row < array.GetLength(0); row++) //цикл по строкам 
    {   
        for (int column = 0; column < array.GetLength(1); column++)// цикл по столбцам 
        {
            for(int col = column + 1; col < array.GetLength(1); col ++) // по столбцам след элемент
            {
                
                if(array[row,column] < array[row,col]) // сравнение текущего и следующего
                {
                   
                   int temp = array[row,column] ; // текущий индекс во временную переменную
                   array[row,column] = array[row,col]; // текущий  который добавляется в массив равен знач из условия
                   array[row,col] = temp;// следующий стал текущим
            
                }
            }
        }
        
        }   
        Console.WriteLine();
        return array;
    }

int[,] matrix = CreateMatrix(3, 3, 0, 10);
PrintMatrix(matrix);
Sorting(matrix);
PrintMatrix(matrix);