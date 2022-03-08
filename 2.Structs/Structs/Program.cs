
Coordinate c = new Coordinate();
Coordinate d = new Coordinate { X = 12, Y = 42 };
Coordinate cChange = c with { X = 13, Y = 43 };
Console.WriteLine(c);

public readonly struct Coordinate
{
    //Default constructor now allowed in C# 10
    public Coordinate()
    {
        X = 0;
        Y = 0;
    }
    public int X { get; init; }
    public int Y { get; init; }
}