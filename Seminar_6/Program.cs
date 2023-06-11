
/*int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] resultArray = GetArray(10, 0, 10);
Console.WriteLine($"Исходный массив: [ {String.Join("; ", resultArray)}]");


*/

/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

*/

/*

Console.WriteLine("Введите несколько чисел");
int length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[length];
int count = 0;
for (int i= 0; i < numbers.Length; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    if (numbers[i] > 0)
    {
        count++;
    }
}

  

Console.WriteLine($"Массив: [ {String.Join("; ", numbers)}]");
Console.WriteLine($"Количество положительных элементов: {count}");

*/
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*
Console.WriteLine("Задайте число k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число k2");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число b2");
int b2 = Convert.ToInt32(Console.ReadLine());

double CrossPointX = 0;
double CrossPointY = 0;
CrossPointX = b2 - b1 / k1 - k2;
CrossPointY = k1 * CrossPointX + b1;
Console.WriteLine("Точка пересечения прямых, заданных вашими координатами (" + CrossPointX +"; "+ CrossPointY + ").");
*/