// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12




int N = InputNumber();
//int res = Sum();
System.Console.WriteLine(Sum());
int Sum()
{
  int result = 0;
  while (N != 0)
  {
    result += N % 10;
    N /= 10;
  }
  return result;
}

int InputNumber()
{
  int number;
  string text;
  while (true)
  {
    Console.Write("Введите число: ");
    text = Console.ReadLine();
    if (int.TryParse(text, out number))
    {
      break;
    }
    System.Console.WriteLine("Не распознанное число, попробуйте еще раз!");
  }
  return number;
}

