//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
const int SIZE = 4;
const int LEFT_RANGE = 100;
const int RIGTH_RANGE = 999;
int[] arr = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGTH_RANGE);
NumberOfEvenNumbers(arr, out int evenNumbersCount);
System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
System.Console.WriteLine($"Количество четных чисел = {evenNumbersCount}");

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
  int[] tempArr = new int[size];
  Random rand = new Random();
  for (int i = 0; i < tempArr.Length; i++)
  {
    tempArr[i] = rand.Next(leftRange, rightRange + 1);
  }
  return tempArr;
}

void NumberOfEvenNumbers(int[] arr, out int evenNumbersCount)
{
  evenNumbersCount = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0)
    {
      evenNumbersCount += 1;
    }
  }
}


// System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
// System.Console.WriteLine(evenNumbersCount);