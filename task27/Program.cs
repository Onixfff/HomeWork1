System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(SumDigits(num));

int SumDigits(int num)
{
    int num2 = num;
    int sum = 0;
    int count = 0;

    if (num2 == 0)
    {
        count++;
    }

    while (num2 > 0)
    {
        count++;
        num2 /= 10;
    }

    for (int i = 0; i < count; i++)
    {
        sum += num % 10;
        num /= 10;
    }

    return sum;
}