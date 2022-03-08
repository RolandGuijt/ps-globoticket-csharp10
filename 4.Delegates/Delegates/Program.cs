
var convert = new ConversionDelegate(Conversion);
DelegateReceiver(convert);

var list = new List<int> { 1, 2, 3, 4 };
var element = list.Single(e => e == 3);

static void DelegateReceiver(ConversionDelegate del)
{
    var result = del("SomeString");
}

static int Conversion(string input)
{
    return int.Parse(input);
}

static int AnotherConversion(string input)
{
    return int.Parse(input) + 1;
}

public delegate int ConversionDelegate(string input);

