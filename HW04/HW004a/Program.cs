//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)

int a = ReadToInt("Введите число A: ");
int b = ReadToInt("Введите число В: ");

// int toDegree = Math.Pow(a, b);
int toDegree = ToDegree(a, b);
Console.WriteLine($"{a}^{b}={toDegree}");

int ToDegree(int val, int pow)
{
    int result = 1;
    int i = 1;
    while (i <= pow)
        {
            result *= val;
            i++;
        }
    return result;
}


int ReadToInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
