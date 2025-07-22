using System;

public class T10
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter mobile number:");
        string mobile = Console.ReadLine();

        if (mobile.Length < 5)
        {
            Console.WriteLine("Mobile number should be at least 5 digits long.");
        }
        else
        {
            string firstPart = mobile.Substring(0, mobile.Length - 5);

            string lastFiveXs = new string('X', 5);

            string result = firstPart + lastFiveXs;

            Console.WriteLine("OUTPUT: " + result);
        }

        Console.ReadLine();
    }
}
