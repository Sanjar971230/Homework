﻿// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


System.Console.WriteLine("Введите число N");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите куб");
for (int i=1; i<=num ; i++ )
{
    int sum = i*i*i;

System.Console.WriteLine($"{sum},");
}