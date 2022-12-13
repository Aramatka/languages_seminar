//Урок 7. Двумерные массивы
/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double [,] BivariateArrayD (int line, int column, int minDot, int maxDot)
{
    double [,] newArray = new double [line, column];
    for (int i =0; i<line; i++)
        for (int j =0; j<column; j++)
    newArray [i,j] = new Random().Next(minDot, maxDot) + Math.Round(new Random().NextDouble(), 3);;
    return newArray;
}

void ShowBivariateArrayD (double [,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}
/*
System.Console.WriteLine("Enter the number of lines M:  ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the number of column N:  ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the minimum number:  ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the maximum number:  ");
int max = Convert.ToInt32(Console.ReadLine());
double[,] array1 = BivariateArrayD (M, N,min, max);

ShowBivariateArrayD (array1); */

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
 
 
int [,] BivariateArray (int line, int column, int minDot, int maxDot)
{
    int [,] newArray = new int [line, column];
    for (int i =0; i<line; i++)
        for (int j =0; j<column; j++)
    newArray [i,j] = new Random().Next(minDot, maxDot);
    return newArray;
}

void ShowBivariateArray (int [,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

int Position (int [,]array, int positionI, int positionJ)
{
  
  int number = array [positionI,positionJ];
    return number;
}

/*
System.Console.WriteLine("Enter the number of lines:  ");
int line = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the number of column:  ");
int column = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the minimum number:  ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the maximum number:  ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array1 = BivariateArray (line, column,min, max);

ShowBivariateArray (array1);
System.Console.WriteLine("Enter the I positiion:  ");
int positionI = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the J position:  ");
int positionJ = Convert.ToInt32(Console.ReadLine());

if (positionI>array1.GetLength(0) || positionJ >array1.GetLength(1) || positionJ <0 || positionI <0 ) 
{
    System.Console.WriteLine("There is no position with the following parameters.");
}
else System.Console.WriteLine($" There is position of element {Position(array1, positionI-1, positionJ-1)}."); */


/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

double [] ArithmeticMeanArray(int [,] source_array)
{
int [] sumarray = new int [source_array.GetLength(1)];
double [] meanarrey = new double [source_array.GetLength(1)];
 for(int j=0; j<source_array.GetLength(1); j++)
    {
        for(int i=0; i<source_array.GetLength(0); i++)
        {
            sumarray [j] = sumarray[j] + source_array [i,j];
            if ( i==source_array.GetLength(0)-1) 
            meanarrey [j] = sumarray[j]*10/source_array.GetLength(0);
            meanarrey [j] = Math.Round(meanarrey [j]/10, 2);

        }
    }
return meanarrey;
}

void ShowArray (double [] array)
{
    for(int i=0; i<array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}
/*
System.Console.WriteLine("Enter the number of lines:  ");
int line = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the number of column:  ");
int column = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the minimum number:  ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the maximum number:  ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array1 = BivariateArray (line, column,min, max);

ShowBivariateArray (array1);

double [] meanarray = ArithmeticMeanArray(array1);

ShowArray (meanarray);*/