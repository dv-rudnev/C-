int lenArray = new Random().Next(15, 26);
int[] numbArray = new int[lenArray];


void FillArray(int[] array)
{
    for (int i = 0; i < lenArray; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < lenArray - 1; i++)
    {
        int minPos = i;

        for (int j = i + 1; j < lenArray; j++)
        {
            if (array[j] < array[minPos]) minPos = j;
        }

        int tmp = array[i];  // a = b
        array[i] = array[minPos];  // b = c
        array[minPos] = tmp;  // c = a
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


FillArray(numbArray);
PrintArray(numbArray);
SelectionSort(numbArray);
PrintArray(numbArray);