Console.Write("Введите пятизначное число: ");
string pul = Convert.ToString(Console.ReadLine());
if (pul.Length == 5)
{
  if (pul[0] == pul[4] && pul[1] == pul[3])
  {
    Console.WriteLine("Является паллиндромом");
  }
  else
  {
    Console.WriteLine("Не является паллиндромом");
  }
}



