using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman3
{
    public class Galgenmannchen
    {
        private ZuErratenesWort Wort; // = new ZuErratenesWort("a");

        public Galgenmannchen(string newWort)
        {
            Wort = new ZuErratenesWort(newWort);
        }
        public string RateBuchstabe(char neuerBuchstabe)
        {
            Wort.NeuGeratenerBuchstabe(neuerBuchstabe);
            return Wort.GetErstelltesWort();
        }
        public void Runden()
        {
            while(!Wort.GetFertigGeraten())
            {
                Ausgaben.AusgabeVorRaten(Wort.GetErstelltesWort());
                //Ausgaben.AusgabeWort(RateBuchstabe(Input.GetChar()));
                Ausgaben.AusgabeNachRaten(RateBuchstabe(Input.GetChar()));

            }
            Console.WriteLine("#######");
            char end = Console.ReadKey().KeyChar;
        }
        
    }
}
