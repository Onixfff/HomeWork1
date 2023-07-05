// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите степень");
int pow = Convert.ToInt32(Console.ReadLine());

int Pow(int num, int pow)
{
    int sum = num;
    for (int i = 1; i < pow; i++)
    {
        sum *= num;
    }
    return sum;
}

System.Console.WriteLine(Pow(num,pow));