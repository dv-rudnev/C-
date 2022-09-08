// 

decimal fRec = 0;
decimal fIte = 0;

decimal FiboRec(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FiboRec(n - 1) + FiboRec(n - 2);
}

decimal FiboIte(int n)
{
    fIte++;
    decimal result = 1,
            f0 = 1,
            f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}


Console.ReadKey();
DateTime dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FiboIte({n}) = {FiboIte(n)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalSeconds);

Console.WriteLine();
Console.ReadKey();
dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FiboRec({n}) = {FiboRec(n)} fRec = {fRec.ToString("### ### ###"), -15}");
    fRec = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalSeconds);
Console.ReadKey();
