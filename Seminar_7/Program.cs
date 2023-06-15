/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
Console.Write("Введите количество строк массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива:");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] resMatrix = GetMatrix(rows, columns, -10, 10);

PrintMatrix(resMatrix);
    

//метод, который создаёт массив
double[,] GetMatrix(int m, int n, int min, int max)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            matrix[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(-10, 10),2);
            
        }
    }
    return matrix;
}
//Метод, который печатает массив

void PrintMatrix(double[,] array)
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


*/


/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет


*/

/*
int[,] resMatrix = GetMatrix(5, 5, 0, 10);

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
Console.WriteLine("Назовите номер позиции элемента в двумерном массиве, а я скажу его значение. Сначала номер строки: ");
int index1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Теперь, номер колонки: ");
int index2 = Convert.ToInt32(Console.ReadLine());

//resMatrix.GetValue int index1 int index2];
int val = 0;
if (val <= resMatrix.Length)
{
    val = resMatrix[index1-1,  index2-1];
    Console.WriteLine("Значение элемента: " + val);
}
else
{
    Console.WriteLine("Элемента с таким индексом нет.");
}





*/

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


*/
/*
int[,] resMatrix = GetMatrix(5, 5, 0, 10);

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


void AverageSumColumn(int[,] matr)
{
    
     for (int i = 0; i < matr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            sum = sum + resMatrix[j,i];
        }
        Console.WriteLine($"Среднее арифм. {i + 1} столбца = {sum / matr.GetLength(0)}");
    }    
}
Console.WriteLine();
AverageSumColumn(resMatrix);
//Метод, который печатает массив



*/
