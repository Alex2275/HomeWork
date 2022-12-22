// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] arr = FillArray();
int[] new_Array = Array();
numberPositive(new_Array, out int positive);
System.Console.WriteLine($"[{String.Join(", ", arr)}]");
System.Console.WriteLine($"Количество положительных чисел = {positive}");

int[] FillArray()
{
  System.Console.Write("Введите количество элементов массива:\t");
  int elementsCount = int.Parse(Console.ReadLine());
  int[] myArray = new int[elementsCount];
  for (int i = 0; i < myArray.Length; i++)
  {
    int sum = myArray[i];
    System.Console.Write($"{sum} ");
  }
  return myArray; ;
}

int[] Array()
{
  for (int i = 0; i < arr.Length; i++)
  {
    System.Console.Write($"\nВведите элемент массива под индексом {i}:\t ");
    arr[i] = int.Parse(Console.ReadLine());
  }
  return arr;
}

void numberPositive(int[] new_Array, out int positive)
{
  positive = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > 0)
    {
      positive++;
    }
  }
}


