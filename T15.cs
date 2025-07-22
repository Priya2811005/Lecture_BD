using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int originalNumber = number;
        int result = 0;

        while (number > 0)
        {
            int digit = number % 10;
            result += digit * digit * digit;
            number /= 10;
        }

        if (result == originalNumber)
        {
            Console.WriteLine(originalNumber + " is an Armstrong number.");
        }
        else
        {
            Console.WriteLine(originalNumber + " is not an Armstrong number.");
        }
    }
}
