// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет



Console.Clear();
int m = inputNumber("Введите число строк M = ");
int n = inputNumber("Ввежите число столбцов N = ");
int[,] arr = newArray(m, n);
PrintArray(arr);
int line = inputNumber("Ввежите число столбцов line = ");
int column = inputNumber("Ввежите число столбцов column = ");
Position(line, column, m, n);

void Position(int line, int column, int m, int n)
{
  if (line > m || column > n)
  {
    System.Console.WriteLine("Такого числа в массиве нет!");
  }
  else
  {
    object c = arr.GetValue(line, column);
    System.Console.WriteLine(c);
  }
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