// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


System.Console.WriteLine("Введите первую точку кординат A");
double A1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите первую точку кординат A");
double B1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите первую точку кординат A");
double C1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите первую точку кординат B");
double A2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите первую точку кординат B");
double B2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите первую точку кординат B");
double C2 = Convert.ToDouble(Console.ReadLine());


double result = Math.Sqrt((A1 - A2) * (B1 - B2) * (C1 - C2));

System.Console.WriteLine("Расстояние между точками " + result);
