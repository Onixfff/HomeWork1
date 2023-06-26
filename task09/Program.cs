/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показываем наибольшую цифру числа.
*/

int randomNumber = new Random().Next(10, 100);
int firstNumber = randomNumber % 10;
int secondBumber = randomNumber / 10;

System.Console.WriteLine(randomNumber);

if(firstNumber > secondBumber) System.Console.WriteLine(firstNumber);
else  System.Console.WriteLine(firstNumber);
