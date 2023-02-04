int GetNumber(string message)
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


int number = GetNumber("Введите пятизначное число:");
if (number%10 == number/10000 || number%100 == number/1000)
Console.Write("ДА");
else
Console.Write("НЕТ");
