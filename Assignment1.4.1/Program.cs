/*
Create a structure named “Point” and 2 data members: X and Y coordinate.
Declare 2 points: P1 and P2. Determine if P2 is to the right or left of P1 or on same axis , by comparing the x xoordinates. 
( if p1.x is more than p2.x , it is to the right )
*/
Point P1 = new Point();
Point P2 = new Point();

P1.X = 3;
P1.Y = 4;
P2.X = 5;
P2.Y = 6;

if (P1.X > P2.X)
{
    Console.WriteLine("P2 is to the left of P1");
}
else if (P1.X < P2.X)
{
    Console.WriteLine("P2 is to the right of P1");
}
else
{
    Console.WriteLine("P2 is on the same axis as P1");
}

struct Point
{
    public int X;
    public int Y;
} 

