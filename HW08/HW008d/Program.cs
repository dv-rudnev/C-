/* 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

int page = 2;
int row = 2;
int column = 2;
int[,,] matrix = new int[row, column, page];

int len = matrix.Length;
int[] randNumb = new int[len];
int index = 0;

// Делаю массив случайных чисел и вывожу его на экран
while (randNumb[len - 1] == 0)
{
    int rnd = new Random().Next(1, len + 1);
    if (Check(rnd, randNumb)) continue;
    else Add(rnd, randNumb);
    Console.Write($"{rnd} ");
}
Console.WriteLine();

// Заполняю матрицу числами из массива и сразу вывожу ее на экран построчно
for (int k = 0; k < matrix.GetLength(2); k++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, j, k] = randNumb[index];
            Console.Write($"{matrix[i, j, k].ToString("00")}({i},{j},{k}) ");
            index++;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



bool Check(int number, int[] array)
{
    bool flag = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            flag = true;
            break;
        }
        else if (array[i] == 0) break;
    }
    return flag;
}

void Add(int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 0)
        {
            array[i] = number;
            break;
        }
    }
}