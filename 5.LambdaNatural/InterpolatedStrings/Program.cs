
using System.Diagnostics;
using System.Text;

var s = "A string";
var i = 12;

var interpolated = $"String: {s}, int: {i}";

var formatted = string.Format("String: {0}, int: {1}", s, i);

var builder = new StringBuilder();
builder.Append($"String: {s}, int: {i}");

Debug.Assert(i == 12, $"String: {s}, int: {i}");



[Obsolete($"Use {nameof(Method2)} instead please")]
static void Method1()
{

}

static void Method2()
{

}
