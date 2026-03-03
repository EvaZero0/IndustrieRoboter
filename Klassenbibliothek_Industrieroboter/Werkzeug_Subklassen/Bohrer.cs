namespace Klassenbibliothek_Industrieroboter.Werkzeug_Subklassen
{
    public class Bohrer : Werkzeug
    {
        private int _groesse;

        public Bohrer(string art, int groesse, int verschleiss) : base(art, verschleiss)
        {
            _groesse = groesse;
        }

        public override string ToString()
        {
            return $"{Art}, {_groesse}mm (Verschleiß: {Verschleiss}%)";
        }
    }
}