/*
# Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

System.Console.Write("Введите 1 число - ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите 2 число - ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber)
    Console.WriteLine("True");
else
    Console.WriteLine("False");