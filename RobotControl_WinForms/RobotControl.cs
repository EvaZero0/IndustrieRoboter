using Klassenbibliothek_Industrieroboter;
using Klassenbibliothek_Industrieroboter.Werkzeug_Subklassen;

namespace RobotControl_WinForms
{
    public partial class RobotControl : Form
    {
        private Industrieroboter roboter = new();
        private List<Werkzeug> werkzeugAuswahl = [];

        private enum WerkzeugArt
        {
            Bohrer,
            Greifer,
            Schweißer
        }

        public RobotControl()
        {
            InitializeComponent();
            InitializeWerkzeugkasten();
            InitializePlatzwahl();
            cbx_NeuesWerkzeug.Items.AddRange(Enum.GetNames<WerkzeugArt>());
            cbx_BohrerGroesse.Items.AddRange([2, 4, 8, 10]);
            derVerschleisser.Start();
        }

        private void InitializeWerkzeugkasten()
        {
            int indexSpeicherung = lb_Werkzeugkasten.SelectedIndex;
            lb_Werkzeugkasten.Items.Clear();
            for (int i = 0; i < roboter.WerkzeugKasten.Length; i++)
            {
                string status;
                if (roboter.WerkzeugKasten[i] == null)
                    status = "leer";
                else if (roboter.WerkzeugKasten[i].Verschleiss >= 100)
                    status = $"{roboter.WerkzeugKasten[i].Art}: zerstört!";
                else
                    status = roboter.WerkzeugKasten[i].ToString();

                lb_Werkzeugkasten.Items.Add($"Platz {i}:\t{status}");
            }
            lb_Werkzeugkasten.SelectedIndex = indexSpeicherung;
        }

        private void InitializePlatzwahl()
        {
            num_Platzwahl.Minimum = 0;
            num_Platzwahl.Maximum = roboter.WerkzeugKasten.Length - 1;
        }

        private void Cbx_NeuesWerkzeug_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool istBohrer = cbx_NeuesWerkzeug.Text == "Bohrer";
            label4.Visible = istBohrer;
            cbx_BohrerGroesse.Visible = istBohrer;
            label5.Visible = istBohrer;
        }

        private void Bt_RoboBestuecken_Click(object sender, EventArgs e)
        {
            if (cbx_WerkzeugAuswahl.SelectedItem == null)
            {
                MessageBox.Show("Bitte wählen Sie ein Werkzeug aus.", "Ungültige Aktion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            var werkzeug = (Werkzeug)cbx_WerkzeugAuswahl.SelectedItem;
            int platz = (int)num_Platzwahl.Value;

            bool erfolgreich = roboter.WerkzeugHinzufuegen(platz, werkzeug);

            if (erfolgreich)
            {
                cbx_WerkzeugAuswahl.Items.Remove(werkzeug);
                InitializeWerkzeugkasten();
            }
            else
                MessageBox.Show("Bitte entfernen Sie erst das Werkzeug von diesem Platz.", "Ungültige Aktion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Bt_Holen_Click(object sender, EventArgs e)
        {
            Werkzeug neuesWerkzeug;

            switch (cbx_NeuesWerkzeug.Text)
            {
                case "Bohrer":
                    if (cbx_BohrerGroesse.Text == "")
                    {
                        MessageBox.Show("Bitte treffen Sie eine Auswahl.", "Ungültige Aktion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        return;
                    }
                    neuesWerkzeug = new Bohrer("Bohrer", Convert.ToInt32(cbx_BohrerGroesse.Text), 0);
                    FuegeZurAuswahlHinzu(neuesWerkzeug);
                    break;
                case "Greifer":
                    neuesWerkzeug = new Greifer("Greifer", 0);
                    FuegeZurAuswahlHinzu(neuesWerkzeug);
                    break;
                case "Schweißer":
                    neuesWerkzeug = new Schweisser("Schweißer", 0);
                    FuegeZurAuswahlHinzu(neuesWerkzeug);
                    break;
                default:
                    MessageBox.Show("Bitte treffen Sie eine Auswahl.", "Ungültige Aktion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
            }
        }

        private void FuegeZurAuswahlHinzu(Werkzeug neuesWerkzeug)
        {
            werkzeugAuswahl.Add(neuesWerkzeug);
            cbx_WerkzeugAuswahl.Items.Add(neuesWerkzeug);
        }

        private void Bt_WerkzeugEntfernen_Click(object sender, EventArgs e)
        {
            if (lb_Werkzeugkasten.SelectedIndex == -1)
            {
                MessageBox.Show("Sie haben keinen Platz ausgewählt.", "Ungültige Aktion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lb_Werkzeugkasten.SelectedItem.ToString().Contains("leer"))
            {
                MessageBox.Show("Dieser Platz ist leer.", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"{lb_Werkzeugkasten.SelectedItem}\nEntfernen?", "Werkzeug entfernen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int index = lb_Werkzeugkasten.SelectedIndex;
                var werkzeug = roboter.WerkzeugKasten[index];
                roboter.WerkzeugEntfernen(index);
                FuegeZurAuswahlHinzu(werkzeug);
                InitializeWerkzeugkasten();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < roboter.WerkzeugKasten.Length; i++)
            {
                Werkzeug? werkzeug = roboter.WerkzeugKasten[i];
                if (werkzeug == null) continue;

                if (werkzeug.Verschleiss < 100)
                {
                    werkzeug.Verschleiss++;

                    if (werkzeug.Verschleiss == 100)
                    {
                        MessageBox.Show($"{werkzeug.Art} auf Platz {i} wurde zerstört!", "Kritisches Ereignis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            InitializeWerkzeugkasten();
        }
    }
}