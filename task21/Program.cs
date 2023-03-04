// напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3d пространстве
System.Console.WriteLine("Введите координаты x точки А: ");
int[] coardsA = new int[3];
coardsA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты y точки A: ");
coardsA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты z точки A: ");
coardsA[2] = Convert.ToInt32(Console.ReadLine());

int[] coardsB = new int[3];
System.Console.WriteLine("Введите координаты x точки B: ");
coardsB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты y точки B: ");
coardsB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты z точки B: ");
coardsB[2] = Convert.ToInt32(Console.ReadLine());

double distance=Math.Sqrt(Math.Pow(coardsB[0]-coardsA[0],2))+(Math.Pow(coardsB[1]-coardsA[1],2)+(Math.Pow(coardsB[2]-coardsA[2],2)));
System.Console.WriteLine(Math.Round( distance,2));