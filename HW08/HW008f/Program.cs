/* 62. Напишите программу, которая заполнит спирально массив 4 на 4.

01 02 03 04
14 15 16 05
13 20 17 06
12 19 18 07
11 10 09 08

*/

int[,] arr = new int[new Random().Next(4, 10), new Random().Next(4, 10)];
int n = arr.GetLength(0);
int m = arr.GetLength(1);

int row = 0;
int col = 0;
int dx = 1;
int dy = 0;
int dirChanges = 0;
int visits = m;

for (int i = 0; i < arr.Length; i++)
{
    arr[row, col] = i + 1;
    // Console.WriteLine($"{visits}");
    if (--visits == 0)
    {
        visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        dirChanges++;
    }

    col += dx;
    row += dy;
}

PrintArray2D(arr);


void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j].ToString("00")} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}





