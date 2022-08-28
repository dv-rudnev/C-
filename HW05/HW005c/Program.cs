// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.


int lenArray = new Random().Next(5, 9);
int[] numbArray = new int[lenArray];


void FillArray(int[] array)
{
    for (int i = 0; i < lenArray; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] FindMinMax(int[] array)
{
    int[] arr = new int[2];
    arr[0] = numbArray[0];
    arr[1] = numbArray[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (numbArray[i] < arr[0]) arr[0] = numbArray[i];
        else if (numbArray[i] > arr[1]) arr[1] = numbArray[i];
    }
    return arr;
}


FillArray(numbArray);
PrintArray(numbArray);

int[] tArr = FindMinMax(numbArray);

PrintArray(FindMinMax(numbArray));
Console.WriteLine($"Разница максимального ({tArr[1]}) и минимального ({tArr[0]}) элементов массива равна {tArr[1] - tArr[0]}.");