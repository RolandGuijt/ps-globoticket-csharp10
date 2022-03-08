using System.Runtime.CompilerServices;


var a = 42;
CheckExpression(a > 0); // a > 0

CheckExpression(true); // true

var b = false;
CheckExpression(b); // b

void CheckExpression(bool condition,
    [CallerArgumentExpression("condition")] string? message = null)
{
    Console.WriteLine($"Condition: {message}");
}
