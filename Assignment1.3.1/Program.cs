bool running = true;

while (running)
{
    Console.WriteLine("<Shape Area Calculator>");
    Console.WriteLine("Please select a shape:");
    Console.WriteLine("1. triangle");
    Console.WriteLine("2. square");
    Console.WriteLine("3. rectangle");
    Console.WriteLine("4. exit");
    int userinput = int.Parse(Console.ReadLine());
    switch (userinput)
    {
        case 1:
        Console.WriteLine("Please enter the base of the triangle:");
        double triangleBase = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the height of the triangle:");
        double triangleHeight = double.Parse(Console.ReadLine());
        CalculateTriangleArea(triangleBase, triangleHeight);
        break;
    
        case 2:
        Console.WriteLine("Please enter the side length of the square:");
        double squareSide = double.Parse(Console.ReadLine());
        CalculateSquareArea(squareSide);
        break;

        case 3:
        Console.WriteLine("Please enter the length of the rectangle:");
        double rectangleLength = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the width of the rectangle:");
        double rectangleWidth = double.Parse(Console.ReadLine());
        CalculateRectangleArea(rectangleLength, rectangleWidth);
        break;
    
        case 4:
            running = false;
            break;
        default:
            Console.WriteLine("Invalid selection.");
            break;
    }
    //Functions
    void CalculateTriangleArea(double triangleBase, double triangleHeight)
    {
        double triangleArea = 0.5 * triangleBase * triangleHeight;
        Console.WriteLine($"The area of the triangle is {triangleArea}");
    }
    void CalculateSquareArea(double squareSide)
    {
        double squareArea = squareSide * squareSide;
        Console.WriteLine($"The area of the square is {squareArea}");
    }
    void CalculateRectangleArea(double rectangleLength, double rectangleWidth)
    {
        double rectangleArea = rectangleLength * rectangleWidth;
        Console.WriteLine($"The area of the rectangle is {rectangleArea}");
    }
}


