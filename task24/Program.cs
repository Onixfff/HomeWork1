int GetSumOfSeries(int from, int to)
{
    int result = 0;
    for(int i = from; i <= to; i++)
    {
        result += i;
    }
    return result;
}

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int sum = GetSumOfSeries(1, number);
System.Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");