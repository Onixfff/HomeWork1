int[,] array1 = CreateArray(2, 2);
int[,] array2 = CreateArray(2, 2);

ShowArray(array1);
System.Console.WriteLine();
ShowArray(array2);
System.Console.WriteLine("Ответ:");
ShowArray(MatrixProduct(array1, array2));

int[,] CreateArray(int m, int n)
{
    Random random = new Random();
    int minRandom = 1;
    int maxRandom = 10;

    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
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

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (j < columns - 1)
            {
                System.Console.Write(array[i, j] + ", ");
            }
            else
            {
                System.Console.Write(array[i, j]);
            }
        }
        System.Console.WriteLine();
    }
}

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        System.Console.WriteLine("Ошибка вычисления\nкол-во столбцов первой матрицы не равно количеству строк второй матрицы.");
    }
    
    int[,] sumMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix2.GetLength(1); j++)
        {
            for(int k = 0; k < matrix1.GetLength(1); k++)
            {
                sumMatrix[i, j] += matrix1[i,k] * matrix2[k, j];
            }
        }
    }

    return sumMatrix;
}