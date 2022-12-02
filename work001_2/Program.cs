Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
  Console.Write($"max = {a}");
}

if (a < b)
{
  Console.Write($"max = {b}");
}

if (a == b)
{
  Console.Write("a = b");
}