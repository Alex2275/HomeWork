Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i < N)
{

  Console.Write($"{i + 1}, ");
  i = i + 2;
}