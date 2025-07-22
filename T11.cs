using System;

public class T11
{
    static void Main(string[] args)
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Gender (M/F): ");
        char gender = Convert.ToChar(Console.ReadLine().ToUpper());  

        if (gender == 'M')
        {
            Console.WriteLine("OUTPUT: Mr. " + name);
        }
        else if (gender == 'F')
        {
            Console.WriteLine("OUTPUT: Ms. " + name);
        }
        else
        {
            Console.WriteLine("Invalid gender entered. Please enter M or F.");
        }

        Console.ReadLine();
    }
}
