﻿Console.WriteLine("Введите цифру");
int a = Convert.ToInt32(Console.ReadLine( ));

Console.WriteLine(a>99 ? a.ToString()[2] : "Нету 3-й цифры");
Console.ReadKey(true);