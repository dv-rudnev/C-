/*  64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5. -> "5, 4, 3, 2, 1"
N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Mgc(number);

void Mgc(int n)
{
    if (n >= 1)
    {
        Console.Write(n + " ");
        Mgc(n - 1);
    }
}

// Console.WriteLine();
// for (int i = number; i > 0; i--)
// {
//     Console.Write(i + " ");
// }