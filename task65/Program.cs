/*
65. Задайте значения M и N. Напишите программу,
 которая выведет все натуральные числа в промежутке от M до N.
*/

void NatureleNum(int number, int count)
{
    if(count >= number)
    {
        System.Console.Write(number + " ");
        NatureleNum(number+ 1, count);
    }
}

NatureleNum(1,5);