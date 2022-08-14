int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    // Console.WriteLine($"{arg1}, {arg2}, {arg3} : {result}");
    return result;
}

int a1 = new Random().Next(1,101);
int a2 = new Random().Next(1,101);
int a3 = new Random().Next(1,101);
int b1 = new Random().Next(1,101);
int b2 = new Random().Next(1,101);
int b3 = new Random().Next(1,101);
int c1 = new Random().Next(1,101);
int c2 = new Random().Next(1,101);
int c3 = new Random().Next(1,101);

// int max1 = Max(a1, a2, a3);
// int max2 = Max(b1, b2, b3);
// int max3 = Max(c1, c2, c3);
// int max = Max(max1, max2, max3);

int max = Max(
    Max(a1, a2, a3), 
    Max(b1, b2, b3), 
    Max(c1, c2, c3));

Console.WriteLine(max);