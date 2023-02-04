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

int x1 = GetNumber("Введите координату Х первой точки");
int y1 = GetNumber("Введите координату Y первой точки");

int x2 = GetNumber("Введите координату Х второй точки");
int y2 = GetNumber("Введите координату Y второй точки");

int x3 = GetNumber("Введите координату Х третьей точки");
int y3 = GetNumber("Введите координату Y третьей точки");

 // Корень((x1-x2)^2 + (y1-y2)^2)
 // Math.Sqrt()
 // Math.Pow(выражение, степень)

double GetDistance (int x1, int x2, int y1, int y2, int x3, int y3)
{
double result = Math.Sqrt(Math.Pow(x1-x2-x3,2) + Math.Pow(y1-y2-y3,2));
return result;
}

System.Console.WriteLine(GetDistance(x1,x2,x3,y1,y2,y3));