﻿/*
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int randomNumber = new Random().Next(100, 1000);
int firstNumber = randomNumber / 100;
int secondNumber = randomNumber % 10;
System.Console.WriteLine($"start - {randomNumber} {firstNumber}{secondNumber}");