﻿int GetNumber(string message)

{
int result = 0;

while (true)
{
Console.WriteLine(message);

if (int.TryParse(Console.ReadLine(), out result))
{
break;
}
else
{
Console.WriteLine("Ввели не число или 0. Повторите ввод");
}
}

return result;
}

// принимает на вход число (N) и
// выдаёт таблицу кубов чисел
int x1 = GetNumber("Введите число");

for (int i = 1; i <= x1; i++)
{
System.Console.Write($"{Math.Pow(i,3)} ");

}