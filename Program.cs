using System;

namespace Method_Class1
{
    // Step 1: Creates a class with a void method that takes two integers as parameters.
    public class MathOperations
    {
        // Void method that performs a math operation on the first integer and displays it.
        public void PerformMathOperation(int number1, int number2)
        {
            // Perform some math operation on the first number
            int result = number1 + 10; // Example: Addition operation

            // Display the first integer to the screen.
            Console.WriteLine($"First integer: {number1}");

            // Display result of the math operation
            Console.WriteLine($"Result After Math Operation:  {result}");

          
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 2: Instantiate the MathOperations class.
            MathOperations mathOperations = new MathOperations();

            // Step 3: Call the method in the class, passing in two numbers.
            int number1 = 5;
            int number2 = 7;
            mathOperations.PerformMathOperation(number1, number2);

            Console.WriteLine();

            // Step 4: Call the method in the class, specifying the parameters by name.
            int anotherNumber1 = 8;
            int anotherNumber2 = 3;
            mathOperations.PerformMathOperation(number1: anotherNumber1, number2: anotherNumber2);

        }
    }
}
