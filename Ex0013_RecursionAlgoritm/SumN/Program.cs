// Сумма чисел от 1 до N. Цикл и рекурсия.

int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}


Console.WriteLine(SumFor(8));
Console.WriteLine(SumRec(8));