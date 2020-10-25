using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Index des aktuellen Panels */
        int PX;

        /* Gesamtes Spielfeld inkl. Randfelder */
        int[,] F = new int[15, 10];

        /* Zeile und Spalte des aktuellen Panels */
        int PZ, PS;

        /* Schwierigkeitsstufe */
        int Stufe;

        /* Eine zunächst leere Liste von Spiel-Panels */
        ArrayList PL = new ArrayList();

        /* Ein Feld von Farben für die Panels */
        Color[] FarbenFeld = {Color.Red,
            Color.Yellow, Color.Green, Color.Blue,
            Color.Cyan, Color.Magenta, Color.Black,
            Color.White};

        /* Konstanten für Status eines Feldpunktes */
        const int Leer = -1;
        const int Rand = -2;

        /* Zufallsgenerator erzeugen und initialisieren */
        Random r = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            int Z, S;

            /* Größe und Ort einstellen */
            this.Size = new Size(225, 440);
            cmdLinks.Size = new Size(40, 28);
            cmdLinks.Location = new Point(16, 15);
            cmdRechts.Size = new Size(40, 28);
            cmdRechts.Location = new Point(96, 15);
            cmdUnten.Size = new Size(40, 28);
            cmdUnten.Location = new Point(56, 50);
            panLinks.Size = new Size(1, 260);
            panLinks.Location = new Point(20, 80);
            panRechts.Size = new Size(1, 260);
            panRechts.Location = new Point(180, 80);
            panUnten.Size = new Size(160, 1);
            panUnten.Location = new Point(20, 340);
            cmdPause.Size = new Size(70, 28);
            cmdPause.Location = new Point(70, 350);

            /* Feld besetzen */
            for (Z = 1; Z < 14; Z++)
            {
                F[Z, 0] = Rand;
                for (S = 1; S < 9; S++)
                    F[Z, S] = Leer;
                F[Z, 9] = Rand;
            }

            for (S = 0; S < 10; S++)
                F[14, S] = Rand;

            /* Initialisierung */
            Stufe = 1;
            NächstesPanel();
        }

        private void NächstesPanel()
        {
            int Farbe;
            Panel p = new Panel();

            /* Neues Panel zur ArrayList hinzufügen */
            PL.Add(p);

            /* Neues Panel platzieren */
            p.Location = new Point(100, 80);
            p.Size = new Size(20, 20);

            /* Farbauswahl für neues Panel */
            Farbe = r.Next(0, 8);
            p.BackColor = FarbenFeld[Farbe];

            /* Neues Panel zum Formular hinzufügen */
            Controls.Add(p);

            /* Index für späteren Zugriff ermitteln */
            PX = PL.Count - 1;

            /* Aktuelle Zeile, Spalte */
            PZ = 1;
            PS = 5;
        }

        private void timT_Tick(object sender, EventArgs e)
        {
            /* Falls es nicht mehr weiter geht */
            if (F[PZ + 1, PS] != Leer)
            {
                /* Oberste Zeile erreicht */
                if (PZ == 1)
                {
                    timT.Enabled = false;
                    MessageBox.Show("Das war's");
                    return;
                }

                F[PZ, PS] = PX;       // Belegen
                AllePrüfen();
                NächstesPanel();
            }
            else
            {
                /* Falls es noch weiter geht */
                Panel p = (Panel)PL[PX];
                p.Top = p.Top + 20;
                PZ = PZ + 1;
            }
        }

        private void AllePrüfen()
        {
            int Z, S;
            bool Neben, Über;
            Neben = false;
            Über = false;

            /* Drei gleiche Panel nebeneinander ? */
            for (Z = 13; Z > 0; Z--)
            {
                for (S = 1; S < 7; S++)
                {
                    Neben = NebenPrüfen(Z, S);
                    if (Neben) break;
                }
                if (Neben) break;
            }

            /* Drei gleiche Panel übereinander ? */
            for (Z = 13; Z > 2; Z--)
            {
                for (S = 1; S < 9; S++)
                {
                    Über = ÜberPrüfen(Z, S);
                    if (Über) break;
                }
                if (Über) break;
            }

            if (Neben || Über)
            {
                /* Schneller */
                Stufe = Stufe + 1;
                timT.Interval = 5000 / (Stufe + 9);

                /* Eventuell kann jetzt noch eine Reihe
                   entfernt werden */
                AllePrüfen();
            }
        }

        /* Falls 3 Felder nebeneinander besetzt */
        private bool NebenPrüfen(int Z, int S)
        {
            int ZX, SX;
            bool ergebnis = false;

            if (F[Z, S] != Leer &&
                    F[Z, S + 1] != Leer &&
                    F[Z, S + 2] != Leer)
            {
                Panel p = (Panel)PL[F[Z, S]];
                Panel p1 = (Panel)PL[F[Z, S + 1]];
                Panel p2 = (Panel)PL[F[Z, S + 2]];

                /* Falls drei Farben gleich */
                if (p.BackColor == p1.BackColor &&
                        p.BackColor == p2.BackColor)
                {

                    for (SX = S; SX < S + 3; SX++)
                    {
                        /* PL aus dem Formular löschen */
                        Control c = (Control)PL[F[Z, SX]];
                        Controls.Remove(c);
                        /* Feld leeren */
                        F[Z, SX] = Leer;

                        /* Panels oberhalb des entladenen
                           Panels absenken */
                        ZX = Z - 1;
                        while (F[ZX, SX] != Leer)
                        {
                            Panel px =
                                (Panel)PL[F[ZX, SX]];
                            px.Top = px.Top + 20;

                            /* Feld neu besetzen */
                            F[ZX + 1, SX] = F[ZX, SX];
                            F[ZX, SX] = Leer;
                            ZX = ZX - 1;
                        }

                    }
                    ergebnis = true;
                }
            }
            return ergebnis;
        }

        /* Falls drei Felder übereinander besetzt */
        private bool ÜberPrüfen(int Z, int S)
        {
            int ZX;
            bool ergebnis = false;

            if (F[Z, S] != Leer && F[Z - 1, S] != Leer &&
                    F[Z - 2, S] != Leer)
            {
                Panel p = (Panel)PL[F[Z, S]];
                Panel p1 = (Panel)PL[F[Z - 1, S]];
                Panel p2 = (Panel)PL[F[Z - 2, S]];

                /* Falls drei Farben gleich */
                if (p.BackColor == p1.BackColor &&
                        p.BackColor == p2.BackColor)
                {

                    /* 3 Panels entladen */
                    for (ZX = Z; ZX > Z - 3; ZX--)
                    {
                        /* PL aus dem Formular löschen */
                        Control c = (Control)PL[F[ZX, S]];
                        Controls.Remove(c);
                        /* Feld leeren */
                        F[ZX, S] = Leer;
                    }
                    ergebnis = true;
                }
            }
            return ergebnis;
        }

        private void cmdLinks_Click(object sender, EventArgs e)
        {
            if (F[PZ, PS - 1] == Leer)
            {
                Panel p = (Panel)PL[PX];
                p.Left = p.Left - 20;
                PS = PS - 1;
            }
        }

        private void cmdRechts_Click(object sender, EventArgs e)
        {
            if (F[PZ, PS + 1] == Leer)
            {
                Panel p = (Panel)PL[PX];
                p.Left = p.Left + 20;
                PS = PS + 1;
            }
        }

        private void cmdUnten_Click(object sender, EventArgs e)
        {
            while (F[PZ + 1, PS] == Leer)
            {
                Panel p = (Panel)PL[PX];
                p.Top = p.Top + 20;
                PZ = PZ + 1;
            }
            F[PZ, PS] = PX;       // Belegen
            AllePrüfen();
            NächstesPanel();
        }

        private void cmdPause_Click(object sender, EventArgs e)
        {
            timT.Enabled = !timT.Enabled;
        }
    }
}
