int[,] array = CreateArray(3, 4);
ShowArray(array);
ArithmeticMeanInColumn(array);

int[,] CreateArray(int m, int n)
{
    Random random = new Random();
    int minRandom = 1;
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
        int rows = array.GetUpperBound(0) + 1;
        int columns = array.GetUpperBound(1) + 1;

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

void ArithmeticMeanInColumn(int[,] array)
{
    float sum = 0;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for(int j = 0; j < columns; j++)
    {
        for(int i = 0; i < rows; i++)
        {
            if (i < rows - 1)
                sum += array[i, j];
            else
                sum = (sum + array[i, j]) / rows;
        }
        System.Console.WriteLine(sum + ", ");
        sum = 0;
    }
}