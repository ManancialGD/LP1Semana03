using System;

namespace ChangeString
{
    class Program
    {
        static void Main()
        {
            Console.Write("String: ");
            string inputString = Console.ReadLine();

            Console.Write("Caráter: ");
            char characterToReplace = Console.ReadKey().KeyChar;
            Console.WriteLine();

            string resultString = SubstituirCaracter(inputString, characterToReplace, 'X');
            Console.WriteLine($"Será impresso: {resultString}");
        }

        static string SubstituirCaracter(string input, char characterToReplace, char replacementCharacter)
        {
            char[] characters = input.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == characterToReplace)
                {
                    characters[i] = replacementCharacter;
                }
            }

            return new string(characters);
        }
    }
}