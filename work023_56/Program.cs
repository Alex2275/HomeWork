//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
Random rand = new Random();
int[,] FillAndPrintArray(int m, int n)
{
  int[,] array = new int[m, n];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = rand.Next(0, 10);
    }
  }
  return array;
}

void PrintArray2D(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      System.Console.Write(arr[i, j] + " ");
    }
    System.Console.WriteLine();
  }
}

int m = inputNumber("Введите число m: ");//GetLength(0)
int n = inputNumber("Введите число n: ");//GetLength(1)
int[,] matrix = FillAndPrintArray(m, n);
PrintArray2D(matrix);
SumStringMatrix(matrix, out int index, out int minsum);
Console.WriteLine($"Строка с минимальной суммой элементов равна {index + 1}. ");

void SumStringMatrix(int[,] matrix, out int index, out int minsum)
{
  index = 0;
  minsum = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      sum += matrix[i, j];
    }
    Console.WriteLine($"Сумма {i + 1} строки = {sum}");
    if (i == 0)
    {
      minsum = sum;
    }
    else if (sum < minsum)
    {
      minsum = sum;
      index = i;
    }
  }
}

