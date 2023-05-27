// Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.

// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123


Console.Write("Введите число");
int number = Convert.ToInt32(Console.ReadLine());


if (number <= 999)

    while (number > 100)

        number = number / 10 % 10;

else if (number > 1000)

    number = number / 100 % 10;

System.Console.WriteLine("вторая число" + number);