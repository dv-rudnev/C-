﻿// 61. Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

int row = 12;
int[,] triangle = new int[row, row];
const int cellWidth = 3;

void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1; // запоняем первый столбец единицами
        triangle[i, i] = 1; // заполняем диагональ единицами
    }

    for (int i = 2; i < row; i++) // со второй строки заполняем так каким должен быть треугольник Паскаля
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

// void PrintTriangle()
// {
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < row; j++)
//         {
//             if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
//         }
//         Console.WriteLine();
//     }
// }

void Magic()
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
            // if (triangle[i, j] / 2 != 0) Console.Write($"*");
            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i + 1);
        Console.WriteLine();
    }
}

Console.ReadKey();
FillTriangle();
// PrintTriangle();
Console.ReadKey();
Magic();