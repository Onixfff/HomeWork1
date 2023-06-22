Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int count = 2;

while (count <= n)
{
    Console.WriteLine(count);
    count += 2;
}