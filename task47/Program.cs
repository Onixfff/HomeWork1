double[,] array = CreateArray(3, 4);
ShowArray(array);

double[,] CreateArray(int m, int n)
{
    Random random = new Random();

    double[,] array = new double[m, n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = random.NextDouble();
        }
    }

    return array;
}

void ShowArray(double[,] array)
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