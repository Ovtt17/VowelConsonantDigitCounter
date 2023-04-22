using System;

namespace CountVowelsConsonantsAndDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a string
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            // Initialize counters for vowels, consonants, and digits
            int vowelCount = 0;
            int consonantCount = 0;
            int digitCount = 0;

            // Loop through each character in the input string, converting it to lowercase
            foreach (char c in inputString.ToLower())
            {
                // If the character is a letter, check if it's a vowel or a consonant
                if (Char.IsLetter(c))
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
                // If the character is a digit, increment the digit count
                else if (Char.IsDigit(c))
                {
                    digitCount++;
                }
            }

            // Display the results to the user
            Console.WriteLine("The input string contains:");
            Console.WriteLine("- {0} vowels", vowelCount);
            Console.WriteLine("- {0} consonants", consonantCount);
            Console.WriteLine("- {0} digits", digitCount);
            
            Console.ReadKey();
        }
    }
}
