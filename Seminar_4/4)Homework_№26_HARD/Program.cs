// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.


System.Console.WriteLine("Введите число");
int sum = int.Parse(Console.ReadLine());


int result = 0;

while (sum > 0)
{
    result++;
    sum=sum / 10;
}

System.Console.WriteLine("Колличество цифр" + result);