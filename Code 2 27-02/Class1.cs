class BasicClass
{
    private int integerValue;
    private string stringValue;

    // Default constructor
    public BasicClass()
    {
        Console.WriteLine("Default constructor called.");
    }

    // Parameterized constructor
    public BasicClass(int intValue, string strValue)
    {
        integerValue = intValue;
        stringValue = strValue;
        Console.WriteLine("Parameterized constructor called.");
    }

    // Destructor
    ~BasicClass()
    {
        Console.WriteLine("Destructor called.");
    }

    // Method to display values
    public void DisplayValues()
    {
        Console.WriteLine($"Integer Value: {integerValue}, String Value: {stringValue}");
    }
}

