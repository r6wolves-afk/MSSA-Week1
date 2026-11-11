bool running = true;
bool showmenu = true;
int userInput = 0;

while (running)
{
    if (showmenu)
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1. addition");
        Console.WriteLine("2. subtraction");
        Console.WriteLine("3. multiplication");
        Console.WriteLine("4. division");
        Console.WriteLine("5. exit");

        userInput = int.Parse(Console.ReadLine());
    }

    switch (userInput)
    {
        case 1:
            Console.WriteLine("addition");
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"The result is: {num1 + num2}");
            break;

        case 2:
            Console.WriteLine("subtraction");
            Console.WriteLine("Enter first number:");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The result is: {num3 - num4}");
            break;

        case 3:

            Console.WriteLine("multiplication");
            Console.WriteLine("Enter first number:");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num6 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The result is: {num5 * num6}");
            break;

        case 4:
            Console.WriteLine("division");
            Console.WriteLine("Enter first number:");
            int num7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num8 = int.Parse(Console.ReadLine());
            if (num8 != 0)
            {
                Console.WriteLine($"The result is: {num7 / num8}");
            }
            else
            {
                Console.WriteLine("Error: cannot divide by zero 0.");
            }
            break;

        case 5:
            Console.WriteLine("Exiting...");
            running = false;
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
    if (running)
    {
        Console.WriteLine("would you like to return to the menu? (y/n)");
        string continueInput = Console.ReadLine();
        if (continueInput == "n")
        {
            showmenu = false;
        }
        else if (continueInput == "y")
        {
            showmenu = true;
        }
        
        while (continueInput != "y" && continueInput != "n")
        {
            Console.WriteLine("Invalid input. Please enter 'y' or 'n':");
            continueInput = Console.ReadLine();
        }
    }
}

  

   




