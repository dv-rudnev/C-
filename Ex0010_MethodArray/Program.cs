int[] array = { 4, 15, 26, 35, 38, 59, 60, 70, 74, 85, 92 };

int n = array.Length;
int find = 70;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}