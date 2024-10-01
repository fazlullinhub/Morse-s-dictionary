using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        private static readonly Dictionary<char, string> morseCodeDict = new Dictionary<char, string>
        {
            {'A', ".-"},
            {'B', "-..."},
            {'C', "-.-."},
            {'D', "-.."},
            {'E', "."},
            {'F', "..-."},
            {'G', "--."},
            {'H', "...."},
            {'I', ".."},
            {'J', ".---"},
            {'K', "-.-"},
            {'L', ".-.."},
            {'M', "--"},
            {'N', "-."},
            {'O', "---"},
            {'P', ".--."},
            {'Q', "--.-"},
            {'R', ".-."},
            {'S', "..."},
            {'T', "-"},
            {'U', "..-"},
            {'V', "...-"},
            {'W', ".--"},
            {'X', "-..-"},
            {'Y', "-.--"},
            {'Z', "--.."},
            {'0', "-----"},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {' ', "/" }
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Write some text to translate in Morse's dictionary:");
            string input = Console.ReadLine().ToUpper();
            string morseCode = ConvertToMorseCode(input);
            Console.WriteLine($"Morse's dictionary: {morseCode}");
        }

        private static string ConvertToMorseCode(string input)
        {
            string morseCode = " ";
            foreach(char c in input)
            {
                if (morseCode.Contains(c))
                {
                    morseCode += morseCodeDict[c] + " ";
                }
                else
                {
                    morseCode += "? ";
                }
            }
            return morseCode.Trim();
        }
    }
}
