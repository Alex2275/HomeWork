// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int inputNumber(string str)
{
  int number;
  string text;
  while (true)
  {
    System.Console.Write(str);
    text = Console.ReadLine();
    if (int.TryParse(text, out number))
    {
      break;
    }
    System.Console.Write("Не распознанное число, попробуйте еще раз!");
  }
  return number;
}

Console.Clear();
System.Console.WriteLine();
int m = inputNumber("Введите M = ");
int n = inputNumber("Введите N = ");
double[,] arr = FillAndPrintArray(m, n);

double[,] FillAndPrintArray(int m, int n)
{
  double[,] array = new double[m, n];
  Random rand = new Random();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = Math.Round(rand.Next(-10, 10 + 1) + rand.NextDouble(), 3); ;
      System.Console.Write(array[i, j] + "\t");
    }
    System.Console.WriteLine();
  }
  return array;
}

