int[,] array = CreateArray(3, 4);
ShowArray(array);
System.Console.WriteLine();
ReturnValueInArray(5, 4, array);

int[,] CreateArray(int m, int n)
{
    Random random = new Random();
    int minRandom = -10;
    int maxRandom = 10;

    int[,] array = new int[m, n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(minRandom, maxRandom);
        }
    }

    return array;
}

void ShowArray(int[,] array)
{
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for(int i = 0; i < rows; i ++)
        {
            for(int j = 0; j < columns; j++)
            {
                if(j < columns -1)
                {
                    System.Console.Write(array[i,j] + ", ");
                }
                else
                {
                    System.Console.Write(array[i,j]);
                }
            }
            System.Console.WriteLine();
        }
}

void ReturnValueInArray(int x, int y, int[,] array)
{
    int rows = array.GetLength(0) + 1;
    int columns = array.GetLength(1) + 1;

    if(x <= rows)
    {
        if(y <= columns)
        {
            System.Console.WriteLine($"Значение по адресу {x}, {y} = {array[x, y]}" );
        }
        else
        {
            System.Console.WriteLine($"{x}, {y} => Такого числа в массиве нету");
        }
    }
    else
    {
        System.Console.WriteLine($"{x}, {y} => Такого числа в массиве нету");
    }
}

