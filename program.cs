using System;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter the first number:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number:");
            int b = int.Parse(Console.ReadLine());

            Calculator.Display();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "+":
                    Console.WriteLine("After adding " + Calculator.Add(a, b));
                    break;

                case "-":
                    Console.WriteLine("After subtracting " + Calculator.Subtract(a, b));
                    break;

                case "*":
                    Console.WriteLine("After multiplying " + Calculator.Multiply(a, b));
                    break;

                case "/":
                    Console.WriteLine("After dividing " + Calculator.Divide(a, b));
                    break;

                case "%":
                    Console.WriteLine("Result " + Calculator.Modulo(a, b));
                    break;

                case "=":
                    Calculator.End();
                    return;

                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
        }
    }
}
