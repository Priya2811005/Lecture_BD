using System;

public class T8
{
	public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();            

        string upperName = name.ToUpper();            

        Console.WriteLine("OUTPUT: " + upperName);   

        Console.ReadLine();
    }
}
