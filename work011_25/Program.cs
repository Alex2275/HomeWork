// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

int A = InputNumber();
int B = InputNumber2();
//int S = degree();
System.Console.WriteLine(degree());
int degree()
{
  int S = 1;
  for (int i = 0; i < B; i++)
  {
    S *= A;
  }
  return S;
}


int InputNumber()
{
  int number;
  string text;

  while (true)
  {
    Console.Write("Введите число А: ");
    text = Console.ReadLine();

    if (int.TryParse(text, out number))
    {
      break;
    }
    System.Console.WriteLine("Не распознанное число, попробуйте еще раз!");
  }
  return number;
}

int InputNumber2()
{
  int number;
  string text;

  while (true)
  {
    Console.Write("Введите число B: ");
    text = Console.ReadLine();

    if (int.TryParse(text, out number))
    {
      break;
    }
    System.Console.WriteLine("Не распознанное число, попробуйте еще раз!");
  }
  return number;
}
