using System;

public class Test
{
    private string myString = "Test";

    public virtual string GetString()
    {
        return myString;
    }

    public string MyString
    {
        set
        {
            myString = value;
        }
    }
}

public class TestDev : Test
{
    public override string GetString()
    {
        return base.GetString() + " (output from the derived class)";
    }
}

class Program
{
    static void Main(string[] args)
    {
        TestDev myObj = new TestDev();
        string result = myObj.GetString();
        Console.WriteLine(result);
    }
}

