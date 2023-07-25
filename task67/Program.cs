/*
67. Напишите программу, которая будет
принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9

*/

int NatureleSumNumber(int number)
{
    if(number != 0)
    {
        return number % 10 + NatureleSumNumber(number / 10);     
    }
    return 0;
}

System.Console.WriteLine(NatureleSumNumber(453));