using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman3
{
    static class Ausgaben
    {
        static public void AusgabeFehlerBuchstabe(char Anzeige)
        {
            Console.WriteLine("Die Eingabe darf nur einen Buchstaben beinhalten! Eingabe: " + Anzeige);
        }

        static public void AusgabeVorRaten(string Anzeige)
        {
            Console.Write("Bisher: " + Anzeige + ", neuer Buchstabe: ");
        }
        static public void AusgabeNachRaten(string Anzeige)
        {
            Console.WriteLine(", neues Wort: " + Anzeige);
        }
        static public void AusgabeWort(string Anzeige)
        {
            Console.Write(Anzeige);
        }
        static public void AusgabeNeuesWort()
        {
            Console.Write("Gebe neues Wort ein. Es sind nur Buchstaben und Leerzeichen erlaubt.");
        }
        static public void AusgabeStart(string Anzeige)
        {
            Console.WriteLine("Starte zu Rate!");
            AusgabeVorRaten(Anzeige);
        }

    }
}
