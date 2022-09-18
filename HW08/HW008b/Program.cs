// 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] array = new int[5, 3];
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Write($"{i + 1}|  ");
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        sum += array[i, j];
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine($"  = {sum}");
}
Console.WriteLine();

int row = MinAmountLine(array);
Console.WriteLine($"Наименьшая сумма элементов в строке {row}.");



int MinAmountLine(int[,] arr)
{
    int minSum = 0;
    int row = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int tmpSum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tmpSum += arr[i, j];
        }
        if (minSum == 0)
        {
            minSum = tmpSum;
            row = i;
        }
        else if (tmpSum < minSum)
        {
            minSum = tmpSum;
            row = i;
        }
    }
    row += 1;
    return row;
}
