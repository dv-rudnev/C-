// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int numb = ReadToInt("Введите число: ");
int len = numb.ToString().Length;

if (len < 3)
{
    Console.Write("У числа нет третьего разряда.");
}
else
{
    int result = numb / 100 % 10;
    Console.Write(result);
}


int ReadToInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
