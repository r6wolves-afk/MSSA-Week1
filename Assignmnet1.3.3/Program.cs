
//Prompt the user to enter the size of the array
Console.WriteLine("Plese enter the size of the array:");
int n = int.Parse(Console.ReadLine());

//Create an array of the specified size
int[] userArray = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"element - {i}: ");
    userArray[i] = int.Parse(Console.ReadLine());
}

//Displays the elements of the array
Console.WriteLine("The elements of the array are:");
for (int i = 0; i < n; i++)
{
    Console.Write(userArray[i] + " ");
   
}
Console.WriteLine();

//Displays the elements reversed
Console.WriteLine("The elements of the array in reverse order are:");
for (int i = n - 1; i >= 0; i--)
{
    Console.Write(userArray[i] + " ");
}
