// Сумма цифр в числа

int numb = ReadToInt("Введите число: ");

int gSum = SumOfDigits(numb);
Console.WriteLine($"Сумма цифр числа {numb} равна {gSum}");


int SumOfDigits(int temp)
{
    int sum = 0;
    while (temp != 0)
        {
        sum += (temp % 10);
        temp /= 10;
        }
    return sum;
}


int ReadToInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
