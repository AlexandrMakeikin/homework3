// напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно полиндромом.
System.Console.WriteLine("введите число ");
string? number = Console.ReadLine();
if (number!.Length < 4 || number!.Length > 6)
{
    System.Console.WriteLine("FATAL ERROR");
}
else if (number!.Length > 4 && number!.Length < 6 && number[0] == number[4])
{
    System.Console.WriteLine("число является полиндромным");
}
else if (number!.Length > 4 && number!.Length < 6 && number[0] > number[4] || number[0] < number[4])
{
    System.Console.WriteLine("число не является полиндромным");
}
 