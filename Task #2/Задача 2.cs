Console.Write("Введите число a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Введите число c: ");
double c = double.Parse(Console.ReadLine());

Console.Write("Максимальное число из трех вышеприведенных: " + Math.Max(a, Math.Max(b, c)));