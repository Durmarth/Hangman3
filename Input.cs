using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman3
{
    public static class Input
    {
        public static char GetChar()
        {
            char newChar;
            newChar = Char.ToLower(Console.ReadKey().KeyChar);
            while (newChar.IsInputWrong())
            {
                Ausgaben.AusgabeFehlerBuchstabe(newChar);
                newChar = Char.ToLower(Console.ReadKey().KeyChar);
            }
            return newChar;
        }
        public static string GetWord()
        {
            string newWord;
            Ausgaben.AusgabeNeuesWort();
            newWord = Console.ReadLine().ToLower();
            while (newWord.IsInputWrong())
            {

                Ausgaben.AusgabeNeuesWort();
                newWord = Console.ReadLine().ToLower();
            }
            return newWord;

        } //input word and check if correct

        public static bool IsInputWrong(this char newGuess)
        {
            return !Char.IsLower(newGuess);
        } //is input character NOT an accepted input
        public static bool IsInputWrong(this string newGuess)
        {
            return !newGuess.All(character => Char.IsLetter(character) || character == ' ');
        }//is input word NOT an accepted input
    }
}
