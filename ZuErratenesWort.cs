using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman3
{
    public class ZuErratenesWort
    {
        private string originalWort;
        private string erstelltesWort;
        //private string gerateneBuchstaben;
        private string umgedrehtesWort;
        private bool fertigGeraten;
        public ZuErratenesWort(string neuesWort)
        {
            fertigGeraten = false;
            originalWort = neuesWort;
            erstelltesWort = new String(originalWort.Select(letter => letter == ' ' ? ' ' : '-').ToArray());
            umgedrehtesWort = originalWort;
        }
        public string GetOriginalWort()
        {
            return originalWort;
        }
        public void SetOriginalWort(string OriginalWortNeu)
        {
            originalWort = OriginalWortNeu;
        }
        
        public string GetErstelltesWort()
        {
            return erstelltesWort;
        }
        public void SetErstelltesWortNeu(char neuBuchstabe)
        {
            int position = umgedrehtesWort.IndexOf(neuBuchstabe);
            while(position>=0)
            {
                umgedrehtesWort = umgedrehtesWort.Remove(position, 1).Insert(position, "-");
                erstelltesWort = erstelltesWort.Remove(position, 1).Insert(position, neuBuchstabe.ToString());
                position = umgedrehtesWort.IndexOf(neuBuchstabe,position);
            }
        }
        private void SetFertigGeraten()
        {
            fertigGeraten = !erstelltesWort.Contains("-");
        }
        public bool GetFertigGeraten()
        {
            return fertigGeraten;
        }
        public void NeuGeratenerBuchstabe(char neuBuchstabe)
        {
            SetErstelltesWortNeu(neuBuchstabe);
            SetFertigGeraten();
        }
        
    }
}
