# Incorrect Property Initialization in C# Constructor

This example demonstrates a common error in C#: incorrect property initialization within a class constructor.  The intended behavior is to initialize `MyProperty` with the value passed to the constructor, but a simple arithmetic error causes unintended modification.

## Bug
The `ExampleClass` constructor incorrectly adds 1 to the input value before assigning it to `MyProperty`. This means the property will always have a value one greater than expected.

## Solution
The solution corrects the assignment in the constructor to initialize `MyProperty` directly with the input value.