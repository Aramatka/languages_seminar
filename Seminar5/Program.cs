// Урок 5. Функции и одномерные массивы
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*int [] RandomArrey (int size)
{
    int [] newArray = new int [size];
    for (int i =0; i<size; i++)
    newArray [i] = new Random().Next(100, 1000);
    return newArray;
}

void ShowArray (int [] array)
{
    for(int i=0; i<array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

int numberOfEven (int []arrayOdd)
{
   int count = 0;
    for(int i=0; i<arrayOdd.Length; i++)
    {
        if (arrayOdd[i]%2==0) count= count+1;
    }
    return count;
}

System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arrayOdd = RandomArrey (size);
ShowArray (arrayOdd);
System.Console.WriteLine($"Количество четных чисел в массиве {numberOfEven (arrayOdd)}.");*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int [] Array (int size, int min, int max)
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

int SumNotEvenPoz(int [] newarrae)
{
    int sum = 0;
        for(int i=1; i<newarrae.Length;  i=i+2)
        sum = sum+newarrae[i];
return sum;
}

System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите минимальное число массива: " );
int minimum = Convert.ToInt32(Console.ReadLine ());
System.Console.WriteLine("Введите максимальное число массива: " );
int maximum = Convert.ToInt32(Console.ReadLine ());
int [] newarray = Array (size, minimum, maximum);
ShowArray (newarray);
System.Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях: {SumNotEvenPoz(newarray)}.");*/


//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*double [] Array (int size)
{
    double [] newArray = new double [size];
    for (int i =0; i<size; i++)
    newArray [i] = new Random().Next(1, 10)+ Math.Round(new Random().NextDouble(), 3);
    return newArray;
}

void ShowArray (double [] array)
{
    for(int i=0; i<array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

double DiffNum(double[] array)
{
    double res = 0;
    double min = array [0];
    double max = array[0];
    for (int j = 0; j<array.Length; j++)
    {
        if (array[j]>max)
        max = array[j];
        if (array[j]<min)
        min = array[j];
    res = max - min;}
    return res;
}

System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double [] newarray = Array (size);
ShowArray (newarray);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {Math.Round(DiffNum(newarray),3)}.");
*/