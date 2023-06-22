Console.WriteLine("Введите 1 число : ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число : ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber)
    Console.WriteLine(firstNumber);
else
    Console.WriteLine(secondNumber);