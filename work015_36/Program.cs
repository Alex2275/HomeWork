// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6]-> 0

const int SIZE = 4;
const int LEFT_RANGE = -100;
const int RIGTH_RANGE = 100;
int[] arr = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGTH_RANGE);
SumOddElements(arr, out int OddElements);
System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
System.Console.WriteLine($"Сумма элементов стоящих на нечетных позициях = {OddElements}");

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

void SumOddElements(int[] arr, out int OddElements)
{
  OddElements = 0;
  for (int i = 1; i < arr.Length; i += 2)
  {
    OddElements = OddElements + arr[i];
  }
}