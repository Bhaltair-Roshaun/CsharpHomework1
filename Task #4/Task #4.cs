Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

for (int b = 2; b <= a; b += 2)
{
    if (b < a - 1)
        Console.Write(b + ", ");
        else
        Console.Write(b + ".");
}