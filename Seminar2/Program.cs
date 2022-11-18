/*Урок 2. Базовые алгоритмы*/
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

/*System.Console.WriteLine("Введите трёхзначное число:");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1<100 || num1>999)
 {System.Console.WriteLine("Число не трёхзначное");}
 else System.Console.WriteLine(num1 % 100 / 10);*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

/*System.Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;
if (len < 3)
{    
    System.Console.WriteLine("третьей цифры нет");
}
else System.Console.WriteLine($"{number[2]}");*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
System.Console.WriteLine("Введите цифру от 1 до 7: ");
int Number = Convert.ToInt32(Console.ReadLine());
if ( Number > 7)
    {
    System.Console.WriteLine($"Цифра {Number} не определяет день недели.");
    }
else
{
    if (Number > 0 && Number < 6)
    {
        System.Console.WriteLine("нет");
    }
    if (Number==6 || Number == 7)
    {
        System.Console.WriteLine("да");
    }
}