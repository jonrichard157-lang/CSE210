using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son."
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("Éter", 12, 18),
                "And neither at any time hath any wrought miracles until after their faith."
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("Alma", 37, 6),
                "By small and simple things are great things brought to pass, and small means in many instances doth confound the wise."
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("Proverbs", 3, 5),
                "Trust in the Lord with all your heart and lean not on your own understanding."
            )
        );

        Random random = new Random();
        int index = random.Next(scriptures.Count);
        Scripture scripture = scriptures[index];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue or type quit:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}