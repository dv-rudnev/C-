// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int day = ReadToInt("Введите число от 1 до 7 включительно: ");

if (day > 0 && day < 8)
{
    if (day > 5)
    {
        Console.Write("Да, это выходной.");
    }
    else
    {
        Console.Write("Увы, день рабочий.");
    }
}
else
{
    Console.Write("Веведнное чисто не соответствует условию.");
}

int ReadToInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}