// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29


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
int m = inputNumber("Введите неотрицательное число m: ");
int n = inputNumber("Введите неотрицательное число n: ");
AkkermanFunction(m, n);

void AkkermanFunction(int m, int n)
{
  Console.Write(Akkerman(m, n));
}

int Akkerman(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  else if (n == 0 && m > 0)
  {
    return Akkerman(m - 1, 1);
  }
  else
  {
    return (Akkerman(m - 1, Akkerman(m, n - 1)));
  }
}