using System;

public class T9
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        string input = Console.ReadLine();

        string toggleCase = ToggleCase(input);

        Console.WriteLine("OUTPUT: " + toggleCase);

        Console.ReadLine();
    }

    static string ToggleCase(string str)
    {
        char[] toggledChars = new char[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];

            if (char.IsUpper(ch))
            {
                toggledChars[i] = char.ToLower(ch);
            }
            else if (char.IsLower(ch))
            {
                toggledChars[i] = char.ToUpper(ch);
            }
            else
            {
                toggledChars[i] = ch;
            }
        }

        return new string(toggledChars);
    }
}

