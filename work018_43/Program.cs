// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

Console.Write("введите значение b1:\t");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число k1:\t");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение b2:\t");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число k2:\t");
double k2 = Convert.ToInt32(Console.ReadLine());

PointIntersection();

void PointIntersection()
{
  double x = (b1 - b2) / (k2 - k1);
  double y = k2 * x + b2;
  Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}; Y: {y}");
}






