/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1, 4
*/

void Power(int n)
{
    if (n < 0)
        n *= -1;
        
    int count = 1;
    while (count <= n )
    {
        System.Console.Write($"{Math.Pow(count, 2)}");

        if (count != n)
            System.Console.Write(", ");
        else
            System.Console.Write(".");

        count++;
    }
}

Power(-5);