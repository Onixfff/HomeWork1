/*
# Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/

int numberFirst= Convert.ToInt32(Console.ReadLine());
if( numberFirst % 7==0 && numberFirst % 23==0)
    Console.WriteLine("true");
else
    Console.WriteLine("false");