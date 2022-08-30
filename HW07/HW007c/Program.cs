/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/


int[,] rndMatrix = new int[new Random().Next(4, 8), new Random().Next(4, 8)];

FillMatrix2D(rndMatrix);
PrintMatrix2D(rndMatrix);
double[] avg = ColumnAverage(rndMatrix);

for (int i = 0; i < avg.Length; i++)
{
    Console.Write($"{avg[i].ToString("0.00")} ");
}


void FillMatrix2D(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

double[] ColumnAverage(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i,j];
        }
        average[j] = sum / matrix.GetLength(0);
    }
    return average;
}

void PrintMatrix2D(int[,] matrix)
{
    Console.WriteLine();
    Console.WriteLine($"Матрица размером {matrix.GetLength(0)}*{matrix.GetLength(1)}");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}