var del = (string s) => int.Parse(s);

PassingOn((string s) => int.Parse(s));

PassingOn(object (string s) => s == "Zero" ? s : int.Parse(s));

static void PassingOn(Delegate converter)
{
    
}


