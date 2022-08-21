// Пооверка на палиндром

Console.WriteLine("Введите пятизначное число: ");
string sNumb = Console.ReadLine();
int len = sNumb.Length;

if (len == 5)
{
    if (sNumb[0] == sNumb[4] && sNumb[1] == sNumb[3])
    {
        Console.WriteLine($"Число {sNumb} палиндром");
    }
    else
    {
        Console.WriteLine($"Число {sNumb} НЕ палиндром");
    }
}
else
{
    Console.WriteLine("Число не пятизначное");
}