int[] array = CreateArray();
System.Console.Write("Массив чисел - ");
ShowArray(array);
System.Console.WriteLine($"\nКол-во четных чисел - {CalkEnentNumbers(array)}");

int[] CreateArray()
{
    Random random = new Random();
    int maxArraySize = 11;
    int minArraySize = 0;
    int maxArrayNumber = 1000;
    int minArrayNumber = 100;
    int[] array2 = new int[random.Next(minArraySize, maxArraySize)];
    for(int i = 0; i < array2.Length; i++)
    {
        array2[i] = random.Next(minArrayNumber, maxArrayNumber);
    }

    return array2;
}

int CalkEnentNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }

    return count;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}