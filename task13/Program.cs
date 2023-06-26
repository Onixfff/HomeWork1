/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
System.Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());
int numberLenght = number.ToString().Length;
double count = 10;
int otvet = 0;
if (numberLenght > 2)
{
    if (numberLenght > 3)
        count = Math.Pow(count, numberLenght - 3);
    otvet = number / (int)count % 10;
    System.Console.WriteLine($"number - {number} -> {otvet}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}