public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        // The bug is here: incorrect initialization
        MyProperty = value + 1; 
    }
}