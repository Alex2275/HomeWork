//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456-> 5
//782-> 8
//918-> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 100 && number < 1000)
{
  int a = number % 100;
  int b = a / 10;
  Console.WriteLine(b);
}
else
{
  Console.WriteLine("Число введено неверно!");
}




