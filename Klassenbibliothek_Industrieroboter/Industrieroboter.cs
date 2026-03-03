namespace Klassenbibliothek_Industrieroboter
{
    public class Industrieroboter
    {
        private const int MaxAnzahlWerkzeuge = 10;
        public Werkzeug[] WerkzeugKasten { get; private set; }

        public Industrieroboter()
        {
            WerkzeugKasten = new Werkzeug[MaxAnzahlWerkzeuge];
        }

        public bool WerkzeugHinzufuegen(int platz, Werkzeug neuesWerkzeug)
        {
            if (platz < 0 || platz > WerkzeugKasten.Length - 1)
                return false;

            if (WerkzeugKasten[platz] != null)
                return false;

            if (WerkzeugKasten.Contains(neuesWerkzeug))
                return false;

            WerkzeugKasten[platz] = neuesWerkzeug;
            return true;
        }

        public bool WerkzeugEntfernen(int platz)
        {
            if (platz < 0 || platz > WerkzeugKasten.Length - 1)
                return false;

            if (WerkzeugKasten[platz] == null)
                return false;

            WerkzeugKasten[platz] = null;
            return true;
        }
    }
}