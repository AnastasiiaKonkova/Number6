//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//P.s. Без создания массива
/*
void CountNum(int size)
{
    int count = 0;
    for (int i = 0; i < size;i++ )
    {
        Console.Write($"Введите число №{i+1}: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) count++;
    }
    Console.Write($"Чисел > 0 введено {count} шт.");
}

Console.Write("Введите колличество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
CountNum(M);
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/* Console.Write("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = 0;
double y = 0;
if ((k1 == k2) && (b1 == b2))
{
Console.Write("Ошибка! Причина: Прямые совпадают.");
}
else if (k1==k2)  
{
Console.Write("Ошибка! Причина: Прямые параллельны.");
}
else
{
x=(b2-b1)/(k1-k2);  
y=(k1*(b2-b1))/(k1-k2)+b1;
Console.WriteLine($"Координаты пересечения прямых X: {Math.Round(x,2)}, Y: {Math.Round(y,2)}");
}
*/