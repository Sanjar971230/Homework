//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.WriteLine("Введите цисло");
int num = Convert.ToInt32(Console.ReadLine());

int result = -1;

if (num >= 100)
{
    while (num > 100)
    {
        num = num % 100;
        num = num % 10;
    }
    result = num;
    System.Console.WriteLine("Третье число" + result);
}

else 
{
    System.Console.WriteLine("Третье число нет");
}