/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, являеться ли оно палиндромом.

14212 - нет
23432 - да
12821 - да
*/

Console.WriteLine("Enter num");
int num = Convert.ToInt32(Console.ReadLine());

//Пришлось обозвать методы по разному из-за отсутствия полиморфизма
void ChecksForPalindromeString(string num)
{
    if (num.ToString().Length == 5)
    {
        if (num[0] == num[4])
        {
            if (num[1] == num[3])
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        else
        {
            Console.WriteLine("False");
        }
    }
    else
    {
        Console.WriteLine("False");
    }
}

void ChecksForPalindromeInt(int num)
{
    if (num >= 10000 && num <= 99999)
    {
        if (num / 10000 == num % 10)
        {
            if ((num / 1000) % 10 == (num % 100) / 10)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        else
        {
            Console.WriteLine("False");
        }
    }
    else
    {
        Console.WriteLine("False");
    }
}

ChecksForPalindromeString(num.ToString());
ChecksForPalindromeInt(num);