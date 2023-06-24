/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
Console.WriteLine("Введите число:");

int N = Convert.ToInt32(Console.ReadLine());

string GetStringOfNumbers( int start, int end)
{
    if( start == end ) return start.ToString();

    return start + ", " + GetStringOfNumbers( start - 1, end);

}
Console.WriteLine(GetStringOfNumbers( N, 1)) ;
*/
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
Console.WriteLine("Введите два числа, а я  посчитаю сумму чисел между ними, включая их самих. Сначала первое:");

int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Теперь второе:");

int N = Convert. ToInt32(Console.ReadLine());

                         
int GetSumOfNumbers( int start, int end)
{
    if( start > end)
    {
        if( start == end ) return end;
        return start +  GetSumOfNumbers( start-1, end );                
         
    }
    if( start == end ) return end;
    return start + GetSumOfNumbers( start+1, end );
   
    
    

}
Console.WriteLine();
Console.WriteLine(GetSumOfNumbers( M, N)) ;



*/
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/*
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

//AkkermanFunction(m,n);


// вызов функции Аккермана
// void AkkermanFunction(int m, int n)
// {

    // Console.Write(Akkerman(m, n)); 
// }
Console.WriteLine(Akkerman(M, N));
// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
/*