/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
 элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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
/*
int [,] SortToLowerArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(1) - 1; n++)
            {
                if (array[i, n] < array[i, n + 1])
                {
                    int temp = array[i, n + 1];
                    array[i, n + 1] = array[i, n];
                    array[i, n] = temp;
                }
            }
        }
    }
    return array;
}

Console.WriteLine("Enter the number of lines:  ");
int line = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the number of column:  ");
int column = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the minimum number:  ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the maximum number:  ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array1 = BivariateArray (line, column,min, max);

ShowBivariateArray (array1);
int[,] sortedarray1 = SortToLowerArray (array1);

ShowBivariateArray (sortedarray1);*/

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

/*int [] SumLineElements(int [,] source_array)
{
int [] sumarray = new int [source_array.GetLength(1)];
 for(int i=0; i<source_array.GetLength(0); i++)
    {
        for(int j=0; j<source_array.GetLength(1); j++)
        {
            sumarray [i] = sumarray[i] + source_array [i,j];
                    }
    }
return sumarray;
}

void ShowArray (int [] array)
{
    for(int i=0; i<array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.WriteLine("Enter the number of lines:  ");
int line = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the number of column:  ");
int column = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the minimum number:  ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the maximum number:  ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array1 = BivariateArray (line, column,min, max);

ShowBivariateArray (array1);

int []sumLine = SumLineElements(array1);
ShowArray (sumLine);

int StringNomber (int [] sumLine)
{
    int i = 0;
    int maxsum = 0;
    if (sumLine[i] > sumLine[i+1]) 
    {
        maxsum = i;
        i++;
    }
return maxsum;
}

Console.WriteLine($"Строка наименьшей суммы элементов: {StringNomber (sumLine) +1}.");*/

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(nums);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}