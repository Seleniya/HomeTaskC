/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
int[,] resMatrix = GetMatrix(5, 5, 0, 10);

PrintMatrix(resMatrix);
Console.WriteLine();

GetChangeMatrix(resMatrix);
    
PrintMatrix(resMatrix);
int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            matrix[i, j] = new Random().Next(0, 10);
            
        }
    }
    return matrix;
}
//Метод, который печатает массив

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void GetChangeMatrix (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {                                                   
        for (int j = 0; j < matr.GetLength(1); j++)     
        {                                             
            for (int k = 0; k < matr.GetLength(1) - 1 - j; k++ )
            {
                 if (matr[i, k] < matr[ i, k + 1])
                 {
                    int temp = matr[i, k ];
                    matr[i, k] = matr[i, k + 1];
                    matr[i, k + 1] = temp;
                
                 }
            }                         
        }
    }
     
}          
*/
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/
/*
int[,] resMatrix = GetMatrix(7, 5, 0, 10);

PrintMatrix(resMatrix);
Console.WriteLine();

GetTheSmollestSumOfRows(resMatrix);
    

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            matrix[i, j] = new Random().Next(0, 10);
            
        }
    }
    return matrix;
}
//Метод, который печатает массив

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void GetTheSmollestSumOfRows (int[,] matr)
{
    int sumOfRows = 0;
    int min = int.MaxValue;
    int index = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        
        for (int j = 0; j < matr.GetLength(1); j++)
        {    
                                  
            sumOfRows = sumOfRows + matr[ i,j ];
                if (min > sumOfRows)
                {
                min = sumOfRows;
                index = i;
                }                              
        }
        Console.WriteLine($" Сумма {i + 1} строки = {sumOfRows}");
        
    }
     Console.WriteLine($"Самая маленькая сумма - это {index + 1} строка\t Спросите меня, как я это сделала, и я отвечу: вообще не знаю,\t но очень рада.");
   

     
}
*/
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
int[,] resMatrix1 = GetMatrix(2, 2, 0, 10);
int[,] resMatrix2 = GetMatrix(2, 2, 0, 10);

PrintMatrix(resMatrix1);
Console.WriteLine();
PrintMatrix(resMatrix2);
Console.WriteLine();
PrintMatrix(GetMultiplyMatr(resMatrix1, resMatrix2));
    

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            matrix[i, j] = new Random().Next(0, 10);
            
        }
    }
    return matrix;
}
//Метод, который печатает массив

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] GetMultiplyMatr(int[,] firstMat, int[,] secondMat)
{
    
    int[,] resultMat = new int[firstMat.GetLength(0), secondMat.GetLength(1)];
    
    for (int i = 0; i < resultMat.GetLength(0); i++)
    {
        for (int j = 0; j < resultMat.GetLength(1); j++)
        {
            
            for (int k = 0; k < firstMat.GetLength(1); k++)
            {
                resultMat[i, j] += firstMat[i,k] * secondMat[k, j];
                
            }
            
        }
    }
    return resultMat;
}
*/
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/
/*
int[,,] resMatrix = Get3dMatrix(3, 3, 3);
PrintMatrix(resMatrix);

int[,,] Get3dMatrix(int n, int m, int l)
{
   
    int[,,] matrix = new int[n, m, l];
    

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           for (int k = 0; k < matrix.GetLength(2); k++)
           {
            matrix[ i, j, k] = new Random().Next(10, 100);
            
           } 
        }
    }  
    
    return matrix;
}

void PrintMatrix(int[,,] array)
{
    int index1 = 0;
    int index2 = 0;
    int index3 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        Console.WriteLine("Страница №" + (i +1));
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int k = 0; k < array.GetLength(2); k++)
           {
                index1 = i;
                index2 = j;
                index3 = k;
                        
                Console.Write($"{array[i, j, k]} [{index1}, {index2}, {index3}] \t");
           }
            Console.WriteLine();
        }
        Console.WriteLine();
    } 
    Console.WriteLine("Чтобы числа не повторялись, не хватило сил. Я и так молодец!");
}

*/
/*

ДОПОЛНИТЕЛЬНАЯ. Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

Начиная с этого урока, учитывается чистота программного кода (именования методов и переменных в нужных стилях, нет "A" и прочего индусского кода).
Имя отражает суть переменной или метода
*/
