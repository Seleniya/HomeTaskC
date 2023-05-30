/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
int a = 0!;
int b = 0!;
    
Console.WriteLine("Напишите число");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите второе число");
b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("число " + a + " больше, чем " + b);
}

else
{
    Console.WriteLine("число " + b + " больше, чем " + a);
}


*/
/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/


  
/*

int Max(int a, int b, int c)
{
    int result = a;
    if (b > result) result = b;
    if (c > result) result = c;
    return result;
}

Console.WriteLine("Напишите число");

int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите второе число");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите третье число");
int c = int.Parse(Console.ReadLine()!);

int max = Max(a, b, c);

Console.WriteLine("Самое большое число из этих - это " + max);




*/


/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
/*
Console.WriteLine("Напишите число");
int a = int.Parse(Console.ReadLine()!);
if (a % 2 == 0)
{
    Console.WriteLine("Это чётное число");
}
else
{
    Console.WriteLine("это нечётное число");
}


*/





/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
 */


Console.WriteLine("Напишите число, а  я покажу все положительные чётные числа до него");
int a = int.Parse(Console.ReadLine()!);
int i = 0;
while ( i < a)
{
    i +=2;
    Console.WriteLine(i);
}