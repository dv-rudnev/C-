// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int lenArray = new Random().Next(10, 16);
int[] numbArray = new int[lenArray];


void FillArray(int[] array)
{
    for (int i = 0; i < lenArray; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < lenArray; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < lenArray; i++)
    {
        if (numbArray[i] % 2 == 0) count += 1;
    }
    return count;
}


FillArray(numbArray);
PrintArray(numbArray);
int count = CountEven(numbArray);
Console.WriteLine($"В массиве {count} четных элементов");