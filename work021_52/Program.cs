// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int m = inputNumber("Введите число строк M = ");
int n = inputNumber("Ввежите число столбцов N = ");
int[,] arr = newArray(m, n);
PrintArray(arr);
System.Console.WriteLine();
ArithmeticMean(arr);

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

int[,] newArray(int m, int n)
{
  int[,] array = new int[m, n];
  Random rand = new Random();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = rand.Next(0, 10);
    }
  }
  return array;
}

void PrintArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
      System.Console.Write(arr[i, j] + " ");
    System.Console.WriteLine();
  }
}

void ArithmeticMean(int[,] arr)
{

  for (int i = 0; i < arr.GetLength(1); i++)
  {
    int sum = 0;
    for (int j = 0; j < arr.GetLength(0); j++)
    {
      sum += arr[j, i];
    }
    double summ = sum;
    double averadge = summ / m;
    double averadgeDobles = Math.Round(averadge, 1);
    System.Console.WriteLine($"Среднее арифметическое число в столбцe =  {averadgeDobles}");
  }
}


