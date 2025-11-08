using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double sum = num1 + num2;
        double diff = num1 - num2;
        double prod = num1 * num2;
        double div = num2 != 0 ? num1 / num2 : double.NaN;

        Console.WriteLine($"\nAddition: {sum}");
        Console.WriteLine($"Subtraction: {diff}");
        Console.WriteLine($"Multiplication: {prod}");
        Console.WriteLine($"Division: {div}");

        if (sum % 2 == 0)
            Console.WriteLine("Sum is Even");
        else
            Console.WriteLine("Sum is Odd");
    }
}
