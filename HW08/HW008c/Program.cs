// 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/* возможно если число столбов в первой равно числу строк во второй 

    B 1 1 1
      1 1 1
A     1 1 1
1 1 1 C .
1 1 1   .
1 1 1 . C
1 1 1

C00 = (A00, A01, A02) * (B00, B10, B20) = A00*B00 + A01*B10 + A02*B20
C21 = (A20, A21, A22) * (B01, B11, B21) = A20*B01 + A21*B11 + A22*B21
*/

int[,] arrayA = new int[2, 2];
int[,] arrayB = new int[2, 2];
int[,] arrayAB = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

FillArr2D(arrayA);
FillArr2D(arrayB);

if (arrayA.GetLength(1) == arrayB.GetLength(0))
{
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            int tmp = 0;
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                tmp += arrayA[i, k] * arrayB[k, j];
            }
            arrayAB[i, j] = tmp;
        }
    }
}
else
{
    Console.WriteLine("Произведение матриц невозможно.");
}

PrintArray2D(arrayA);
PrintArray2D(arrayB);
PrintArray2D(arrayAB);


void FillArr2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 4);
        }
    }
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