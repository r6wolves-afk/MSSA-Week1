Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());


if (num2 == 0)
{
    Console.WriteLine("Cannot divide by zero.");
}

else
{
    int result = num1 / num2;
    int quotient = num1 / num2;
    int remainder = num1 % num2;

    Console.WriteLine("Result: " + result);
    Console.WriteLine("Quotient: " + quotient);
    Console.WriteLine("Remainder: " + remainder);
}

