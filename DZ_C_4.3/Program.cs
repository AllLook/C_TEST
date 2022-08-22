
int [] CreateArray(int Lng) // функция создания массива
{
    int [] array = new int[Lng]; // создаем массив с кол вом элементов
    for(int i = 0; i < Lng; i++) 
    {
        array[i] = new Random().Next(); // заполняем массив случайными элементами
        
    }
    return array; 
}

void PrintArray( int [] array) // функция для вывода массива
{
    int Len = array.Length; // переменная с длинной массива
    for( int i = 0; i < Len; i++)
    {
        Console.WriteLine($"{array[i]}" ); // по очереди выводим элементы массива
    }
}


PrintArray(CreateArray(8));