using System;

class LoopsAndFunctions
{
    static void PrintFactorial(int n)
    {
        long fact = 1;
        for (int i = 1; i <= n; i++)
            fact *= i;
        Console.WriteLine($"Factorial of {n} = {fact}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("For loop (1 to 10):");
        for (int i = 1; i <= 10; i++)
            Console.Write(i + " ");

        Console.WriteLine("\n\nForeach loop (1 to 10):");
        int[] nums = {1,2,3,4,5,6,7,8,9,10};
        foreach (int n in nums)
            Console.Write(n + " ");

        string input;
        do
        {
            Console.Write("\n\nEnter number for factorial (or 'exit'): ");
            input = Console.ReadLine();
            if (input != "exit")
            {
                int num = Convert.ToInt32(input);
                PrintFactorial(num);
            }
        } while (input != "exit");
    }
}

