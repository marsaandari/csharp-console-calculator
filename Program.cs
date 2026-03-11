// We are gonna make a calculator that can perform basic arithmetic operations
// like addition, subtraction, multiplication, and division.

// We will create functions for each operation and then call them in the Main method to demonstrate their usage.

public static class Calculator
{
    public static double Add(double a, double b)
    {
        return a + b;
    }
    public static double Subtract(double a, double b)
    {
        return a - b;
    }
    public static double Multiply(double a, double b)
    {
        return a * b;
    }
    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return a / b;
    }

    static void Main()
    {
        Console.WriteLine("Enter a number:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter another number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter an operation (+, -, *, /):");
        var operation = Console.ReadLine();

        switch (operation)
        {
            case "+":
                Console.WriteLine($"Result: {Add(num1, num2)}");
                break;
            case "-":
                Console.WriteLine($"Result: {Subtract(num1, num2)}");
                break;
            case "*":
                Console.WriteLine($"Result: {Multiply(num1, num2)}");
                break;
            case "/":
                try
                {
                    Console.WriteLine($"Result: {Divide(num1, num2)}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
            default:
                Console.WriteLine("Invalid operation.");
                break;
        }

        Console.WriteLine("Do you want to perform another calculation? (y/n)");
        if (Console.ReadLine()?.ToLower() == "y")       
        {
            Console.Clear(); // Clear the console for a new calculation
            Main(); // Call Main again to perform another calculation
        }
    }

}