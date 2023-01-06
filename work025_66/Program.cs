// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

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
int m = inputNumber("Введите число m: ");
int n = inputNumber("Введите число n: ");

SumFromMToN(m, n);

void SumFromMToN(int m, int n)
{
  Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
  int res = m;
  if (m == n)
    return 0;
  else
  {
    m++;
    res = m + SumMN(m, n);
    return res;
  }
}