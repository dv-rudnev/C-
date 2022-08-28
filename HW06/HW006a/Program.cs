/*
    Пользователь вводит с клавиатуры M чисел через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223 -> 4
*/

Console.Write("Введите числа через зяпятую: ");
string inputStr = Console.ReadLine();

int count = 0;
string tmpStr = string.Empty;

for (int i = 0; i < inputStr.Length; i++)
{
    if (inputStr[i] != ',') tmpStr += inputStr[i];
    else
    {
        if (Convert.ToInt32(tmpStr) > 0) count++;
        tmpStr = string.Empty;
    }
}
if (Convert.ToInt32(tmpStr) > 0) count++;

Console.WriteLine($"Введено {count} чисел больше 0.");
