/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Enter num");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter degree");
int degree = Convert.ToInt32(Console.ReadLine());

Power(num, degree);

void Power(int n, int degree)
{
    if (n < 0)
        n *= -1;

    int count = 1;
    while (count <= n)
    {
        System.Console.Write($"{Math.Pow(count, degree)}");

        if (count != n)
            System.Console.Write(", ");
        else
            System.Console.Write(".");

        count++;
    }
}