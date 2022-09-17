int M = 4;
int N = 8;

int PrintNum(int M, int N)
{

    if (M == 0 && N == 0) // если оба числа равны 0
        return 0;
    else if (M == N) // если числа равны
        return M;
    else if (M > N) // если исходное меньше конечного
        return -1; // как говорилось ранее при отриц результате возвращаем -1
    else
        return M + PrintNum(M + 1, N); // сама рекурсия


    //Console.WriteLine($"Сумма чисел : {PrintNum(4,8)}"); // А НЕЛЬЗЯ В МЕТОДЕ INT СРАЗУ ПРОПИСЫВАТЬ ВЫВОД?


}

PrintNum(M, N);
Console.WriteLine($"Сумма чисел : {PrintNum(4, 8)}");