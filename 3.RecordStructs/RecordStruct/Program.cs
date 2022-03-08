
Coordinate c = new Coordinate(12, 42) { Z = 54 };
Coordinate d = c with { Z = 54 };
var (x, y) = c;
Console.WriteLine(c);
Console.WriteLine(c == d);

//Positional properties are mutable by default!
//Adding readonly will make the properties get/init
public readonly record struct Coordinate(int X, int Y)
{
    public int Z { get; init; } = 0;
}