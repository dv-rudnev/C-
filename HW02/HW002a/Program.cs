// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int numb = ReadToInt("Введите трехзначное число: ");
int len = numb.ToString().Length;

if (len != 3)
{
    Console.WriteLine("Число не трехзначное.");
}
else
{
    Console.WriteLine(Center(numb));
}


int ReadToInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Center(int param)
{
    int result = ((param / 10) % 10);
    return result;
}
