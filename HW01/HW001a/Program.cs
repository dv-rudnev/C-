// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine(a + " больше " + b);
}
else if (b > a)
{
    Console.WriteLine(b + " больше " + a);
}
else
{
    Console.WriteLine("Числа равны");
}