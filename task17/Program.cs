int GetNumberOfQuarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

int quarter = GetNumberOfQuarter(-4, 2);
if (quarter > 0)
    System.Console.WriteLine(quarter);
else
    System.Console.WriteLine("Ошибка");