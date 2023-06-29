/*
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/
string QuarterRange(int quarter )
{
    if (quarter == 1) return "x > 0; y > 0";
    else if (quarter == 2) return "x < 0; y > 0";
    else if (quarter == 3) return "x < 0; y < 0";
    else if (quarter == 4) return "x > 0; y < 0";
    else "Invalid value";
}
for (int i = 0; i <= 4; i++)
{
    System.Console.WriteLine(QuarterRange(i));
}