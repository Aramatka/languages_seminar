// Урок 6. Одномерные массивы. Продолжение
/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */ 

/*
int [] EnterM(int m)
{
    int [] ArreyM = new int [m]; 
    for (int i =0; i<m; i++)
    {
    System.Console.WriteLine("Ввeдите числo") ;
    ArreyM [i] = Convert.ToInt32(Console.ReadLine());
    }
return ArreyM;
}

void ShowArray (int [] array)
{
    for(int i=0; i<array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}


int CountAboveZero(int []arreyM)
{
    int count=0;
    for(int i=0; i<arreyM.Length; i++)
    if (arreyM[i]>0) 
    count = count+1;
return count;
}

System.Console.WriteLine("Здравствуйте. Напишите, сколько чисел будете вводить.");
int m = Convert.ToInt32(Console.ReadLine()) ;

int [] arreyM = EnterM(m);
ShowArray(arreyM);
System.Console.WriteLine($"Пользователь ввëл {CountAboveZero(arreyM)} чисел больше 0.");*/



/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Х=(в2-в1) /(К1-к2) 
У=к1*х+в1

 */
 //int PointX(int b1, int k1, int b2, int k2)
  void PointX()
 {
    System.Console.WriteLine("Найдём точку пересечения двух прямых.");
    System.Console.WriteLine("Введите b1 для первой прямой.");
    int b1 = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите k1 для первой прямой.");
    int k1 = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите b2 для второй прямой.");
    int b2 = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите k2 для второй прямой.");
    int k2 = Convert.ToInt32(Console.ReadLine());
    if (k1==k2)     System.Console.WriteLine($"Прямые параллельны.");
    else
    {
    double coordinateXb = b2 - b1;
    double coordinateXk = k1 - k2;
    double coordinateX = coordinateXb / coordinateXk;
    double coordinateY = k1 * coordinateX + b1;
    System.Console.WriteLine($"Точка пересечения двух прямых ({coordinateX}, {coordinateY}).");
    }
 }
  PointX();