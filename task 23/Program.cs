// Напишите программу,которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N



System.Console.WriteLine("введите число: ");
int num =Math.Abs( Convert.ToInt32(Console.ReadLine()));
for (int i = 1; i < num; i++)
{
    System.Console.Write(Math.Pow(i, 3) + " ");
}