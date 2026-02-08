using System;

public static class Calculator
{
    public static void Display()
    {
        Console.WriteLine("Choose an Operation" +
            "\n + for Addition" +
            "\n - for Subtraction" +
            "\n * for Multiplication" +
            "\n / for Division" +
            "\n % for Modulo" +
            "\n = for Exit");
    }

    public static int Add(int a, int b) => a + b;

    public static int Subtract(int a, int b) => a - b;

    public static int Multiply(int a, int b) => a * b;

    public static int Divide(int a, int b) => a / b;

    public static int Modulo(int a, int b) => a % b;

    public static void End()
    {
        Console.WriteLine("***Exiting Calculator***\n:)");
    }
}
