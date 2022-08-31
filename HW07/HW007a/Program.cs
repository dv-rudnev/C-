/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


int rows = new Random().Next(3, 6);
int columns = new Random().Next(3, 6);

double[,] matrix = new double[rows, columns];

// заполняем матрицу
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(-9, 10) + Math.Round(new Random().NextDouble(), 2);
    }
}

// вывожу матрицу
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j].ToString("0.00") + "  ");
    }
    Console.WriteLine();
}
Console.WriteLine();