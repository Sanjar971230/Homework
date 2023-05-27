//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите число недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
    System.Console.WriteLine("Понедельник нет");
else if (number == 2)
    System.Console.WriteLine("Вторник нет");
else if (number == 3)
    System.Console.WriteLine("Среда нет");
else if (number == 4)
    System.Console.WriteLine("Четверг нет");
else if (number == 5)
    System.Console.WriteLine("Пятница нет");
else if (number == 6)
    System.Console.WriteLine("Суббота Да");
else if (number == 7)
    System.Console.WriteLine("Воскресенье Да");

else System.Console.WriteLine("Вы введил не правильное число");
