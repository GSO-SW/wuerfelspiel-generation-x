using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        int anzahlSeiten;
        string artWuerfel;
        int augenWuefel;
        int maxSeiten;
        int minSeiten;
        int letztesErgebnis;
        bool gesichert;
        Random rnd;


         public Wuerfel()
        {

        }

        public Wuerfel(int anzahlSeiten)
        {

        }
        public int AnzahlSeiten
        {
            get
            {
                return anzahlSeiten;
            }
        }

        public string ArtWuerfel
        {
            get
            {
                return artWuerfel;
            }
        }

        public int AugenWert
        {
            get
            {
                return AugenWert;
            }
        }

        public int MaxSeiten
        {
            get
            {
                return maxSeiten;
            }
        }

        public int MinSeiten
        {
            get
            {
                return minSeiten;
            }
        }

        public int LetztesErgebnis
        {
            get
            {
                return letztesErgebnis;
            }
        }

        public bool Gesichert
        {
            get
            {
                return gesichert;
            }
            set
            {
                gesichert = Gesichert;
            }
        }







    }

    
}














