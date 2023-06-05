/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
Console.WriteLine("Напишите мне 2 числа, а я возведу первое в степень второго. Сначала первое:");
int number_1 =  int.Parse(Console.ReadLine()!);
Console.WriteLine("Теперь второе:");
int number_2 =  int.Parse(Console.ReadLine()!);
double number_3 = Math.Pow(number_1, number_2);
Console.WriteLine("Число " + number_1 + " в степени " + number_2 + " равно " + number_3 + ".");

*/

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

public static uint RecursionSum(uint x) => x==0 ? 0 : x%10+RecursionSum(x/10);

*/



/*

int num = 0!;
var isInputCorrect = false;

do
{
    Console.WriteLine("Напишите какое-нибудь число, а я сосчитаю сумму его цифр");
    link_1: isInputCorrect = int.TryParse(Console.ReadLine(), out num);
    if (!isInputCorrect)
    {
        Console.WriteLine("здесь не только число, напишите число");
        goto link_1;
    }
}
while(!isInputCorrect);

int? sum = 0;

  
while (num > 0)
{
 
    sum = sum + num % 10;
    num = num /10 ;
 
}            

            
 Console.WriteLine("Сумма цифр этого числа " + sum);
*/
/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
/*
int size = 8;
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(90);
}
Console.WriteLine($"Массив: [ {String.Join("; ", array)}]");
*/