// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int lenArray = new Random().Next(5, 9);
int[] numbArray = new int[lenArray];


void FillArray(int[] array)
{
    for (int i = 0; i < lenArray; i++)
    {
        array[i] = new Random().Next(1, 11);
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

int SumOdds(int[] array)
{
    int sum = 0;
    for (int i = 0; i < lenArray; i++)
    {
        if (i % 2 != 0) sum += numbArray[i];
        // Console.WriteLine($"{i} - {numbArray[i]} - {sum}");
    }

    return sum;
}


FillArray(numbArray);
PrintArray(numbArray);
int sum = SumOdds(numbArray);
Console.WriteLine($"Сумма элементов массива с нечетным индексом равна {sum}");