using System;

public class Substring_broken
{
    const char Search = 'p';

    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());
        
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            var a = text[i];
            if (text[i] == Search)
            {
                hasMatch = true;

                int length = jump + 1;

                if (length  + i >= text.Length)
                {
                    length = text.Length - i;
                }
                
                string matchedString = text.Substring(i, length);
                Console.WriteLine(matchedString);
                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
