/* 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int m = new Random().Next(5,11);
int n = new Random().Next(15,31) + m;

Console.WriteLine($"Сумма чисел от {m} до {n} включительно, равна {Sum(m, n)}");

int Sum(int a, int b)
{
    int sum = 0;
    for (int i = a; i <= b; i++)
    {
        sum += i;
    }
    return sum;
}