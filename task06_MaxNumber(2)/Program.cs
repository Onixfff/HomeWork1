Console.WriteLine("Введите 1 число : ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число : ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число : ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;
if(max < secondNumber)
    max = secondNumber;
if(max < thirdNumber)
    max = thirdNumber;

Console.WriteLine(max);
