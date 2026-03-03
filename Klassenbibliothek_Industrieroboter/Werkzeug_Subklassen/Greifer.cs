namespace Klassenbibliothek_Industrieroboter.Werkzeug_Subklassen
{
    public class Greifer(string art, int verschleiss) : Werkzeug(art, verschleiss)
    {
        public override string ToString()
        {
            return $"{Art} (Verschleiß: {Verschleiss}%)";
        }
    }
}