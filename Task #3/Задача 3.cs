Console.Write("Введите число a: ");
double a = double.Parse(Console.ReadLine());
double b = a % 2;
switch (b)
{
    case 0: System.Console.WriteLine("Число a четное"); break;
    default: System.Console.WriteLine("Число a нечетное"); break;
}