// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


System.Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

int cub, sum = 0, result;

if
  (num > 9999 && num > 9999)
{
    for (result = num; num != 0; num = num / 10)
    {
        cub = num % 10;
        sum = sum * 10 + cub;
    }
    if (result == sum)

        System.Console.WriteLine("Да + {result}");

    else

        System.Console.WriteLine("Нет+ {result}");

}
