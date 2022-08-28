/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1
y = k2 * x + b2
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9
-0,5; -0,5
*/


string[] arrayVarName = { "k1", "b1", "k2", "b2" };
double[] arrayVarValues = new double[4];

Console.WriteLine();
Console.WriteLine("Введите коэффициенты линейных уравнений.");
for (int i = 0; i < arrayVarValues.Length; i++)
{
    arrayVarValues[i] = ReadToInt($"Введите коэффициент {arrayVarName[i]}: ");
}
Console.WriteLine();

double x = 0;
double y = 0;

if (arrayVarValues[0] == arrayVarValues[2]) Console.WriteLine("Графики функций не пересекаются.");
else if (arrayVarValues[1] == arrayVarValues[3]) Console.WriteLine($"Графики функций пересекаютсяв точке (0; {arrayVarValues[1]}).");
else
{
    x = (arrayVarValues[3] - arrayVarValues[1]) / (arrayVarValues[0] - arrayVarValues[2]);
    y = arrayVarValues[0] * x + arrayVarValues[1];
    Console.WriteLine($"Графики функций пересекаются в точке ({x}; {y}).");
}


int ReadToInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}