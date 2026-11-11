Console.WriteLine("Please enter your first nunmber: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter your second number: ");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber == secondNumber)
{
    Console.WriteLine($"{firstNumber} and {secondNumber} are equal.");
}

else
{
    Console.WriteLine($"{firstNumber} and {secondNumber} are not equal.");
}

