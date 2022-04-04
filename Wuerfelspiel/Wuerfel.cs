using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        int anzahlSeiten;
        string artWuerfel;
        int augenWuefel;
        int max;
        int min;
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

        public int Max
        {
            get
            {
                return max;
            }
        }

        public int Min
        {
            get
            {
                return min;
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














