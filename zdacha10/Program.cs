
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите цифру");
int a = Convert.ToInt32(Console.ReadLine( ));

Console.WriteLine(a>99 ? a.ToString()[1] : "");
Console.ReadKey(true);