/*Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет
*/

Console.Write("Первое число - ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число - ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

if(numberFirst == numberSecond * numberSecond)
    Console.WriteLine("true");
else
    Console.WriteLine("false");