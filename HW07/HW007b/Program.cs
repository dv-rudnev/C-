/*
    Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет. Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
*/


// создал матрицу случайного размера
int[,] rndMatrix = new int[new Random().Next(1, 10), new Random().Next(1, 10)];

// получаю индекс искомого элемента
Console.WriteLine();
Console.Write("Введите позицию искомого элемента в случайной матрице, в формате 'yx',\n(при условии, что матрица размером не больше 9*9):   ");
string strElementIndex = Console.ReadLine();

// конвертирую и пишу в массив индекс искомого элемента
int[] arrElementIndex = { 0, 0 };
for (int i = 0; i < arrElementIndex.Length; i++)
{
    arrElementIndex[i] = Convert.ToInt32(strElementIndex[i].ToString());
}

FillMatrix2D(rndMatrix);
PrintMatrix2D(rndMatrix);

if (arrElementIndex[0] > rndMatrix.GetLength(0) - 1 || arrElementIndex[1] > rndMatrix.GetLength(1) - 1)
{
    Console.WriteLine("Элемента с таким индексом в матрице нет.");
}
else
{
    Console.WriteLine($"{rndMatrix[arrElementIndex[0], arrElementIndex[1]]}");
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

void PrintMatrix2D(int[,] matrix)
{
    Console.WriteLine();
    Console.WriteLine($"Матрица размером {matrix.GetLength(0)}*{matrix.GetLength(1)}");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
