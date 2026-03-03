namespace Klassenbibliothek_Industrieroboter
{
    public abstract class Werkzeug
    {
        public string Art { get; private set; }
        public int Verschleiss { get; set; }

        public Werkzeug(string art, int verschleiss)
        {
            Art = art;
            Verschleiss = verschleiss;
        }

        public override string ToString()
        {
            return $"{Art} (Verschleiß: {Verschleiss}%)";
        }
    }
}