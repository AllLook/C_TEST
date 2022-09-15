int M = 1;
int N = 5;

void PrintNum(int M, int N)
{
    if (M > N)
        return;

    Console.Write($"{M} ");

    PrintNum(M + 1, N);

}

PrintNum(M, N);
