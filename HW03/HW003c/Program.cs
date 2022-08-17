// Таблица кубов ряда чисел

int numb = ReadToInt("Введите число : ");

for (int i = 1; i <= numb; i++)
{ 
    if (i != numb)
    {
        Console.Write($"{i * i * i}, ");
    }
    else
    {
        Console.Write($"{i * i * i}");
    }
}


int ReadToInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
