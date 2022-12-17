// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


const int SIZE = 4;
const int LEFT_RANGE = -10;
const int RIGTH_RANGE = 10;
double[] arr = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGTH_RANGE);
DifferenceMaximumAndMinimumElements(arr, out double difference);
System.Console.WriteLine("[" + string.Join("; ", arr) + "]");
difference = Math.Round((difference), 3);
System.Console.WriteLine($"Разницу между максимальным и минимальным элементов массива = {difference}");

double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
  double[] tempArr = new double[size];
  Random rand = new Random();
  for (int i = 0; i < tempArr.Length; i++)
  {
    tempArr[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 3);
  }
  return tempArr;
}

void DifferenceMaximumAndMinimumElements(double[] arr, out double difference)
{
  difference = 0;
  double max = arr[0];
  double min = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > max)
    {
      max = arr[i];
    }
    else if (arr[i] < max)
    {
      min = arr[i];
    }
  }
  if (min > 0)
  {
    difference = max - min;
  }
  else if (min < 0)
  {
    difference = max - (-min);
  }
}