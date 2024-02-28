class Program
{
    static void Main()
    {
        // Example of using the BasicClass
        Console.WriteLine("Creating object using default constructor:");
        BasicClass obj1 = new BasicClass();
        obj1.DisplayValues();

        Console.WriteLine("\nCreating object using parameterized constructor:");
        BasicClass obj2 = new BasicClass(27, "pq");
        obj2.DisplayValues();

        // The destructors will be called when objects go out of scope or when explicitly set to null
        obj1 = null;
        obj2 = null;
        GC.Collect(); // Force garbage collection
    }
}