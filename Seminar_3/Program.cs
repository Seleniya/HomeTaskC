/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53



*/


//Задача 19
/*
int a = 0!;
var isInputCorrect = false;

do
{
    Console.WriteLine("Напишите пятизначное число, а я скажу палиндром это или нет");
    isInputCorrect = int.TryParse(Console.ReadLine(), out a);
}
while(!isInputCorrect);

if (a / 9999 > 0 && a / 100000 < 10)
{
   

}
else
{
  Console.WriteLine("Это не пятизначное число. Напишите пятизначное.");
  a = int.Parse(Console.ReadLine()!);

} 
              
int b = 0!;
int c = 0!;
b = int.Parse(a.ToString().Replace("0","4").Replace("1","3"));// 
c = Convert.ToInt32(b);

if ( a == c)
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это НЕ палиндром");
}
*/

//Задача 21

/*
Console.WriteLine("Я умею рассчитать расстояние между двумя точами в 3D пространстве. Напишите мне число, которое означает координату x1");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("напишите мне число, которое означает координату y1");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("напишите мне число, которое означает координату z1");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("ещё надо число, которое означает координату x2");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("и число, которое означает координату y2");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("напишите мне число, которое означает координату z2");
int z2 = int.Parse(Console.ReadLine()!);

double a = (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));
a = Math.Round(a, 1);
Console.WriteLine("Расстояние между этими точками в пространстве = " + a);
*/
/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/
/*
Console.WriteLine("Я посчитаю кубы всех чисел от 1 до вашего числа. Напишите ваше число.");
int number = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= number; i++ )
Console.WriteLine(Math.Pow(i, 3));
Console.WriteLine("Я молодЕц!");
*/