// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


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
int n = inputNumber("Введите число n: ");
int m = 1;
number(n, m);

void number(int n, int m)
{
  if (m > n)
  {
    return;
  }
  else
  {
    number(n, m + 1);
    System.Console.Write($"{m} ");
  }
}



