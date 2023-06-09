/*int[] CreateArray(int N)
{
    int[] arrayA = new int[N * 2 + 1];
    for (int i = -N; i <= N; i++)
    {
        arrayA[i + N] = i;
    }
    
    return arrayA;
}

int[]array = CreateArray(6);
Console.WriteLine(array);
*/
/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

*/
/*
int [] GetArray = new int[10];
Random rand = new Random();
for (int i = 0; i < GetArray.Length; i++)
{   
    GetArray[i] = rand.Next(100, 1000);
    Console.WriteLine(GetArray[i]);
}
int evenNumber = 0;
for (int i = 0; i < GetArray.Length; i++)
{
    if (GetArray[i] %2==0)
    {
       evenNumber ++;
    }
    
}

Console.WriteLine($"Количество чётных чисел массива {evenNumber}" );
*/
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

*/
int size = 10;
int [] GetArray = new int[size];
Random rand = new Random();
for (int i = 0; i < GetArray.Length; i++)
{   
    GetArray[i] = rand.Next(100);
    Console.WriteLine(GetArray[i]);
}
int sumEvenI = 0;
for (int i = 0; i < GetArray.Length; i++)
{
    if (i %2==0)
    {
       sumEvenI += GetArray[i];
       
    }
    
}

Console.WriteLine($"Сумма элементов массива, стоящих на чётном месте {sumEvenI}" );

/*

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

*/