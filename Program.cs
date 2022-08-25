using System;

namespace Hangman3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Galgenmannchen newGame = new Galgenmannchen(Input.GetWord());
            Console.WriteLine("Start in Programm");
            newGame.Runden();
        }
    }
}
