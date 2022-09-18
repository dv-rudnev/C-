// 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] array2D = new int[3, 9];
for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        array2D[i, j] = new Random().Next(0, 11);
    }
}

PrintArray2D(array2D);
Sort2D(array2D);
PrintArray2D(array2D);



void Sort2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        SortRow(array2D, i);
    }
}

void SortRow(int[,] arr, int row)
{
    int left = 0,
        right = arr.GetLength(1) - 1;

    while (left < right) // до того как лев.индекс меньше прав.индекс
    {
        for (int i = left; i < right; i++) // идем слева на право
        {
            if (arr[row, i] < arr[row, i + 1]) // если слева меньше чем справа
            {
                SwapInRow(array2D, row, i, i + 1); // то меняем местами
            }
        }
        --right; // сдвигаем правую границу влево и используем
        for (int i = right; i > left; i--) // и идем справа на лево
        {
            if (arr[row, i] > arr[row, i - 1]) // если справа больше чем слева
            {
                SwapInRow(array2D, row, i, i - 1); // то меяем местами
            }
        }
        ++left; // сдвигаем левую границу вправо и используем
    }
}

void SwapInRow(int[,] arr, int r, int a, int b)
{
    int tmp = arr[r, a];
    arr[r, a] = arr[r, b];
    arr[r, b] = tmp;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}