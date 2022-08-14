int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    // Console.WriteLine($"{arg1}, {arg2}, {arg3} : {result}");
    return result;
}

int[] array = { 13, 21, 32, 46, 54, 62, 79, 86, 91 };

int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));

Console.WriteLine(max); 