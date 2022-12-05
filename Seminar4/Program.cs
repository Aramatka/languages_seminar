/* Урок 4. Функции
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
/*
int Degree (int number, int degree_number)
{
    int count = 1;
    int result = 1;
    while (count <=degree_number) 
        {result = result * number;
        count ++;
        }
    return result;
}

System.Console.WriteLine("Введите число А: " );
int numberA = Convert.ToInt32(Console.ReadLine ());
System.Console.WriteLine("Введите число В: " );
int degree_numberB = Convert.ToInt32(Console.ReadLine ());
if (degree_numberB<0) System.Console.WriteLine("Повторите попытку. ВВедите пожалуйста натуральное значение степени.");
else
System.Console.WriteLine("Результат возведения числа А в степень В равен " + Degree(numberA, degree_numberB) );*/


/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

/*void Summa (int number)
{
    int count = 0;
    int sum = 0;
    if (number<0) number = -number;
    
    while (number > 0 )
    {
        sum = sum + number%10;
        number = number/10;
        count ++;
    }
    System.Console.WriteLine("Сумма чисел в числе " + sum +".");
}

System.Console.WriteLine("Введите число: " );
int num = Convert.ToInt32(Console.ReadLine ());
Summa (num);*/

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
/*
/*int [] Array (int size, int min, int max)
{
    int [] newArray = new int [size];
    for (int i =0; i<size; i++)
    newArray [i] = new Random().Next(min, max+1);
    return newArray;
}

void ShowArray (int [] array)
{
    for(int i=0; i<array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}
    

int size = 8;
System.Console.WriteLine("Введите минимальное число массива: " );
int minimum = Convert.ToInt32(Console.ReadLine ());
System.Console.WriteLine("Введите максимальное число массива: " );
int maximum = Convert.ToInt32(Console.ReadLine ());
int [] newarrae = Array (size, minimum, maximum);
ShowArray (newarrae);
*/