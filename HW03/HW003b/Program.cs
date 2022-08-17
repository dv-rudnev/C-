// Длина отрезка в 3D

int x1 = ReadToInt("Введите X1: ");
int y1 = ReadToInt("Введите Y1: ");
int z1 = ReadToInt("Введите Z1: ");
int x2 = ReadToInt("Введите X2: ");
int y2 = ReadToInt("Введите Y2: ");
int z2 = ReadToInt("Введите Z2: ");

int a = x2 - x1;
int b = y2 - y1;
int c = z1 - z2;

double length = Math.Sqrt(a * a + b * b + c * c);
Console.WriteLine($"Длинна отрезка {length}");

int ReadToInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
