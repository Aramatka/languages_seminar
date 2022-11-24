//Урок 3. Базовые алгоритмы. Продолжение
/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
/*void Palindrome (string number)
{
    int len = number.Length;
    if (len == 5)
    {
        if (number[0]==number[4] && number[1]==number[3]) 
        {
            System.Console.WriteLine("да");
        }
        else System.Console.WriteLine("нет");
    }
    else
    {
    System.Console.WriteLine("Ошибка. Нужно пятизначное число.");
    }
}
System.Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();
Palindrome (num);*/



/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/


/*double Distance (int x1, int y1, int z1,int x2, int y2,  int z2)
{
double length = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
return length;
}
Console.Write("Введите координату хA: ");
int xA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату yA: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату zA: ");
int zA = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите координату хB: ");
int xB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату yB: ");
int yB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату zB: ");
int zB = Convert.ToInt32(Console.ReadLine());

double dist = Distance (xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точкми: {dist:f3}");*/


/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

void Cube(int number)
{
    int num = 1;
    while (num <= number)
    {
        int res = num*num*num;
        Console.Write($"{res}, ");
        num++;
    }
}

Console.Write("Введите число: ");
int nomer = Convert.ToInt32(Console.ReadLine());
if (nomer >= 1)
{
  System.Console.Write($"{nomer} ->");
  Cube(nomer);
}
else System.Console.WriteLine("Значениие требуется больше 0.");