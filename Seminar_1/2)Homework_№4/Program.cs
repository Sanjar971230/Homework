//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int max = 0;

Console.Write("Введите первое число");
int cum1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int cum2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число");
int cum3 = Convert.ToInt32(Console.ReadLine());

if (cum1 > max)
{
    max = cum1;
}
if (cum2 > max)
{
    max = cum2;
}
if (cum3 > max)
{
    max = cum3;
}
System.Console.WriteLine("max = " + max);