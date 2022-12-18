// Урок 9. Рекурсия
/*Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

 /*
void ShouNumbers (int n)
{
if (n<=0) System.Console.WriteLine("Введите натуральное число") ;
Console.Write(n +" ") ;
if (n>1) ShouNumbers (n-1);
}
 
ShouNumbers (5); */

/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
/*
 
int SumNumbers (int n, int m) 
{
if (n<1 && m<1) System.Console.WriteLine("Число должно быть натуральное") ;
if (m<n) return m+SumNumbers (n, m +1);
if (n<m) return n+SumNumbers ( n +1, m);
else return n;
}
 
int sum = SumNumbers (1, 15);
Console.Write($" Сумма натуральных элементов в промежутке от M до N {sum}"); */


/* Задача: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную*/
 /*

int BinSystem (int num) 
{
    int res;
    if (num != 0)
    {
        res = (num % 2) + 10 * BinSystem(num / 2);
        Console.Write(res);
        return 0;
    }
    else return 0;
    
}

System.Console.WriteLine("Введите  число: ");
int number = Convert.ToInt32(Console.ReadLine());
BinSystem (number); */
 
