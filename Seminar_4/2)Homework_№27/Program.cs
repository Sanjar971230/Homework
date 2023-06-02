// Задача 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 - 11

// 82 - 10

// 9012 - 12


System.Console.WriteLine("Введите число");
int sum = Convert.ToInt32(Console.ReadLine());

int result = 1;



if (sum > 0) ;
{
    result = sum % 10 + sum / 10 % 10 + sum / 10 / 10;
}


System.Console.WriteLine("Сумма в числе" + result);