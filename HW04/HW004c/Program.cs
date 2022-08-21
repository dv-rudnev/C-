// Вывод массива длинной N на экран

int lenArray = ReadToInt("Введите количество элементов в массиве: ");

int[] numbArray = new int[lenArray];

FillArray(numbArray);
PrintArray(numbArray);


void FillArray(int[] arr)
{
    int index = 0;
    while (index < lenArray)
        {
        arr[index] = new Random().Next(1, 101);
        index++;
        }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        if (index != count - 1)
        {
            Console.Write(arr[index] + ", ");
        }
        else
        {
            Console.Write(arr[index]);
        }
        index++;
    }
    Console.Write("]");
}

int ReadToInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}