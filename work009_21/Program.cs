int[] point = new int[6];
System.Console.Write("Введите координаты х1: ");
point[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты y1: ");
point[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты z1: ");
point[2] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты x2: ");
point[3] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты y2: ");
point[4] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты z2: ");
point[5] = Convert.ToInt32(Console.ReadLine());

double res1 = Math.Pow((point[3] - point[0]), 2);
double res2 = Math.Pow((point[4] - point[1]), 2);
double res3 = Math.Pow((point[5] - point[2]), 2);
double result = Math.Sqrt(res1 + res2 + res3);

double num = Math.Truncate(result * 100) / 100;

System.Console.WriteLine(num);