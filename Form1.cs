using System.Drawing.Text;
using System.Xml;

namespace Zoo
{
    public partial class Form1 : Form
    {
        private Datenbank db;
        private List<Kontinent> liKont;
        private List<Tierart> liTierarten;
        private List<Gehege> liGehege;
        private List<Tier> liTiere;
        private List<Pfleger> liPfleger;
        private List<Gehege_Pfleger> liGehPfl;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Datenbank();
            dispKontinente();
            dispTierarten();
            anzahlTierarten();
            dispGehege();
            dispTiere();
            dispGehegeTiere();
            dispPfleger();
            dispGehegePfleger();
        }

        private void dispGehegeTiere()
        {
            dgvGehegeMitTieren.Rows.Clear();
            var liste = db.getGehegeMitTiere();
            foreach (var item in liste)
            {
                dgvGehegeMitTieren.Rows.Add(item.Gehege, item.Tier);
            }

        }

        private void dispKontinente()
        {
            liKont = db.getKontinente();
            lbKontinent.Items.Clear();
            cbGehegeKontinent.Items.Clear();
            foreach (Kontinent ko in liKont)
            {
                // von jeden Datensatz Name in die Liste hinzufügen
                lbKontinent.Items.Add(ko.Name1);
                // combobox in Gehege mit existierenden Kontinenten ausfüllen
                cbGehegeKontinent.Items.Add(ko.Name1);
            }
        }

        private void dispTierarten()
        {
            liTierarten = db.getTierarten();
            lbTierart.Items.Clear();
            cbTierTierart.Items.Clear();
            foreach (Tierart ti in liTierarten)
            {
                lbTierart.Items.Add(ti.TierartName1);
                cbTierTierart.Items.Add(ti.TierartName1);
            }
        }

        private void dispGehege()
        {
            liGehege = db.getGehege();
            dgvGehege.Rows.Clear();
            cbTierGehege.Items.Clear();
            cbGehege.Items.Clear();
            foreach (Gehege ge in liGehege)
            {
                // Name eines Datensatzes aus Liste Kontinente erzeugen, dessen ID mit Fremdschlüssel aus Gehege übereinstimmt
                // x - vorgeschlagenes Objekt
                string s = liKont.Find(x => x.KontinentID1 == ge.GehegeKontinent).Name1;
                dgvGehege.Rows.Add(ge.GehegeName, s);
                cbTierGehege.Items.Add(ge.GehegeName);
                cbGehege.Items.Add(ge.GehegeName);
            }
        }

        private void dispTiere()
        {
            liTiere = db.getTiere();
            dgvTiere.Rows.Clear();
            foreach (Tier t in liTiere)
            {
                string s = liGehege.Find(x => x.GehegeID == t.TierGehege).GehegeName;
                string st = liTierarten.Find(x => x.TierartID1 == t.TierTierart).TierartName1;
                dgvTiere.Rows.Add(t.TierName, t.TierGeburtsjahr, s, st);
            }
        }

        private void dispPfleger()
        {
            liPfleger = db.getPfleger();
            dgvPfleger.Rows.Clear();
            cbPflNachname.Items.Clear();
            foreach (Pfleger pfl in liPfleger)
            {
                dgvPfleger.Rows.Add(pfl.PflegerVorname, pfl.PflegerNachname);
                cbPflNachname.Items.Add(pfl.PflegerNachname);
            }
        }

        private void dispGehegePfleger()
        {
            liGehPfl = db.getGehegePfleger();
            dgvGehegePfleger.Rows.Clear();
            foreach (Gehege_Pfleger gepfl in liGehPfl)
            {
                string ge = liGehege.Find(x => x.GehegeID == gepfl.Gehegeid).GehegeName;
                string pflv = liPfleger.Find(x => x.PflegerID == gepfl.Pflegerid).PflegerVorname;
                string pfln = liPfleger.Find(x => x.PflegerID == gepfl.Pflegerid).PflegerNachname;
                string hp;
                if(gepfl.Hauptpfleger == 1)
                {
                    hp = "Ja";
                }
                else
                {
                    hp = "Nein";
                }
                dgvGehegePfleger.Rows.Add(ge, pflv, pfln, hp);
            }

        }

        private void btnKontSpeichern_Click(object sender, EventArgs e)
        {
            if (tbKontinent.Text != "")
            {
                // -1 heißt, dass Datensatz nicht existiert, also Insert
                // Update, wenn ID bereits vorhanden ist, also einen bestimmten Datensatz schon in Liste ausgewählt ist
                int nr = lbKontinent.SelectedIndex == -1 ? -1 : liKont[lbKontinent.SelectedIndex].KontinentID1;
                Kontinent ko = new Kontinent(nr, tbKontinent.Text);
                db.neuKontinent(ko);
                dispKontinente();
            }
        }

        private void btnDelKontinent_Click(object sender, EventArgs e)
        {
            if (lbKontinent.SelectedIndex != -1)
            {
                // Where id = id von in der Liste ausgewähltes Datensatzes
                int which = liKont[lbKontinent.SelectedIndex].KontinentID1;
                db.delKontinent(which);
                dispKontinente();
            }
        }

        // wenn einen bestimmten Datensatz ausgewählt ist, wird textbox wieder mit existierenden Daten ausgefüllt sein
        private void lbKontinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbKontinent.SelectedIndex != -1)
            {
                tbKontinent.Text = liKont[lbKontinent.SelectedIndex].Name1;
            }
        }

        private void btnKontNeu_Click(object sender, EventArgs e)
        {
            lbKontinent.SelectedIndex = -1;
        }

        private void anzahlTierarten()
        {
            int anzahl = db.getAnzahlTierarten();
            label9.Text = "Anzahl der Tierarten: " + anzahl.ToString();
        }

        private void btnTierartSpeichern_Click(object sender, EventArgs e)
        {
            if (tbTierart.Text != "")
            {
                int nr = lbTierart.SelectedIndex == -1 ? -1 : liTierarten[lbTierart.SelectedIndex].TierartID1;
                Tierart ti = new Tierart(nr, tbTierart.Text);
                db.neuTierart(ti);
                dispTierarten();
                anzahlTierarten();
            }
        }

        private void lbTierart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTierart.SelectedIndex != -1)
            {
                tbTierart.Text = liTierarten[lbTierart.SelectedIndex].TierartName1;
            }
        }

        private void btnTierartLoeschen_Click(object sender, EventArgs e)
        {
            if (lbTierart.SelectedIndex != -1)
            {
                int which = liTierarten[lbTierart.SelectedIndex].TierartID1;
                db.delTierart(which);
                dispTierarten();
                anzahlTierarten();
            }
        }

        private void btnTierartNeu_Click(object sender, EventArgs e)
        {
            lbTierart.SelectedIndex = -1;
        }


        private void btnGehegeSpeichern_Click(object sender, EventArgs e)
        {
            if (tbGehege.Text != "")
            {
                int nr = -1;
                Gehege gh = new Gehege(nr, tbGehege.Text, liKont[cbGehegeKontinent.SelectedIndex].KontinentID1);
                db.neuGehege(gh);
                dispGehege();
            }
        }

        private void dgvGehege_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGehege.CurrentRow != null && dgvGehege.CurrentRow.Index >= 0 && dgvGehege.CurrentRow.Index < liGehege.Count)
            {
                int index = dgvGehege.CurrentRow.Index;
                tbGehege.Text = liGehege[index].GehegeName;
                index = liKont.FindIndex(x => x.KontinentID1 == liGehege[index].GehegeKontinent);
                cbGehegeKontinent.SelectedIndex = index;
            }
            else
            {
                tbGehege.Clear();
                cbGehegeKontinent.SelectedIndex = -1;
            }
        }

        private void btnGehegeLoeschen_Click(object sender, EventArgs e)
        {
            if (dgvGehege.CurrentRow != null && dgvGehege.CurrentRow.Index >= 0 && dgvGehege.CurrentRow.Index < liGehege.Count)
            {
                try
                {
                    int which = liGehege[dgvGehege.CurrentRow.Index].GehegeID;
                    db.delGehege(which);
                    dispGehege();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Löschen: " + ex.Message, "Fehler");
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie ein gültiges Gehege zum Löschen aus.", "Hinweis");
            }
        }

        private void btnGehegeNeu_Click(object sender, EventArgs e)
        {
            dgvGehege.ClearSelection();
        }

        private void dgvTiere_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTiere.CurrentRow != null && dgvTiere.CurrentRow.Index >= 0 && dgvTiere.CurrentRow.Index < liTiere.Count)
            {
                int index = dgvTiere.CurrentRow.Index;
                tbTierName.Text = liTiere[index].TierName;
                tbTierGeb.Text = liTiere[index].TierGeburtsjahr.ToString();
                index = liGehege.FindIndex(x => x.GehegeID == liTiere[index].TierGehege);
                cbTierGehege.SelectedIndex = index;
                index = dgvTiere.CurrentRow.Index;
                index = liTierarten.FindIndex(x => x.TierartID1 == liTiere[index].TierTierart);
                cbTierTierart.SelectedIndex = index;
            }
            else
            {
                tbTierName.Clear();
                tbTierGeb.Clear();
                cbTierGehege.SelectedIndex = -1;
            }
        }

        private void btnTierSpeichern_Click(object sender, EventArgs e)
        {
            if (tbTierName.Text != "")
            {
                int nr = -1;

                Tier tier = new Tier(nr, tbTierName.Text, tbTierGeb.Text, liGehege[cbTierGehege.SelectedIndex].GehegeID, liTierarten[cbTierTierart.SelectedIndex].TierartID1);
                db.neuTier(tier);
                dispTiere();
                dispGehegeTiere();
            }
        }

        private void btnTierNeu_Click(object sender, EventArgs e)
        {
            dgvTiere.ClearSelection();
        }

        private void btnTierLoeschen_Click(object sender, EventArgs e)
        {
            if (dgvTiere.CurrentRow.Index != -1)
            {
                if (dgvTiere.CurrentRow != null && dgvTiere.CurrentRow.Index >= 0 && dgvTiere.CurrentRow.Index < liTiere.Count)
                {
                    try
                    {
                        int which = liTiere[dgvTiere.CurrentRow.Index].Tierid;
                        db.delTier(which);
                        dispTiere();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fehler beim Löschen: " + ex.Message, "Fehler");
                    }
                }
                else
                {
                    MessageBox.Show("Bitte wählen Sie ein gültiges Gehege zum Löschen aus.", "Hinweis");
                }
            }
        }

        private void btnPflegerSpeichern_Click(object sender, EventArgs e)
        {
            if (tbPflegerVorn.Text != "")
            {
                int nr = -1;
                if (dgvPfleger.CurrentRow != null && dgvPfleger.CurrentRow.Index != -1)
                {
                    nr = liPfleger[dgvPfleger.CurrentRow.Index].PflegerID;
                }
                Pfleger pfl = new Pfleger(nr, tbPflegerVorn.Text, tbPflegerNachn.Text);
                db.neuPfleger(pfl);
                dispPfleger();
            }
        }

        private void btnPflegerLoeschen_Click(object sender, EventArgs e)
        {
            if (dgvPfleger.CurrentRow.Index != -1)
            {
                int which = liPfleger[dgvPfleger.CurrentRow.Index].PflegerID;
                db.delPfleger(which);
                dispPfleger();
            }
        }

        private void btnPflegerNeu_Click(object sender, EventArgs e)
        {
            dgvPfleger.ClearSelection();
            liPfleger[dgvPfleger.CurrentRow.Index].PflegerID = -1;
        }

        private void dgvPfleger_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPfleger.CurrentRow.Index != -1 && dgvPfleger.CurrentRow.Index < liPfleger.Count)
            {
                int index = dgvPfleger.CurrentRow.Index;
                tbPflegerVorn.Text = liPfleger[index].PflegerVorname;
                tbPflegerNachn.Text = liPfleger[index].PflegerNachname;

            }
        }

        // Datensätze der Tabelle Tiere in CSV Datei speichern
        private void btnTierToCSV_Click(object sender, EventArgs e)
        {

            Datei datei = new Datei("Tier.csv");
            datei.schreibeDatei("TierID;Name;Geburtsjahr;GehegeID;TierartID");

            foreach (Tier t in liTiere)
            {
                string gehegeName = liGehege.Find(x => x.GehegeID == t.TierGehege).GehegeName;
                string tierartName = liTierarten.Find(x => x.TierartID1 == t.TierTierart).TierartName1;
                string csv = t.Tierid.ToString() + ";" + t.TierName + ";" + t.TierGeburtsjahr.ToString() + ";" + gehegeName + ";" + tierartName;
                datei.schreibeDatei(csv);
            }

        }

        private void btnGehPflSpeichern_Click(object sender, EventArgs e)
        {
            if (cbPflNachname.SelectedIndex != -1)
            {
                int nr = -1;
                int hp = rbHauptpflegerJa.Checked ? 1 : 0;
                Gehege_Pfleger gepfl = new Gehege_Pfleger(nr, liGehege[cbGehege.SelectedIndex].GehegeID, liPfleger[cbPflNachname.SelectedIndex].PflegerID, hp);
                db.neuGehegePfleger(gepfl);
                dispGehegePfleger();
            }
        }

        private void dgvGehegePfleger_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGehegePfleger.CurrentRow.Index != -1)
            {
                int index = dgvGehegePfleger.CurrentRow.Index;

                if (index >= 0 && index < liGehPfl.Count)
                {
                    int indexg = liGehege.FindIndex(x => x.GehegeID == liGehPfl[index].Gehegeid);
                    cbGehege.SelectedIndex = indexg;
                    int indexp = liPfleger.FindIndex(x => x.PflegerID == liGehPfl[index].Pflegerid);
                    cbPflNachname.SelectedIndex = indexp;
                    int hp = liGehPfl[index].Hauptpfleger;
                    if (hp == 1)
                    { 
                        rbHauptpflegerJa.Checked = true; 
                    }
                    else
                    { 
                        rbHauptpflegerNein.Checked = true; 
                    }
                }
            }
        }

        private void btnGehegePflegerNeu_Click(object sender, EventArgs e)
        {
            dgvGehegePfleger.ClearSelection();
            liGehPfl[dgvGehegePfleger.CurrentRow.Index].GehPflID = -1;
        }

        private void btnGehegePflegerLoeschen_Click(object sender, EventArgs e)
        {
            if(dgvGehegePfleger.CurrentRow.Index != -1)
            {
                int which = liGehPfl[dgvGehegePfleger.CurrentRow.Index].GehPflID;
                db.delGehegePfleger(which);
                liGehPfl[dgvGehegePfleger.CurrentRow.Index].GehPflID = -1;
                dispGehegePfleger();
                
            }
            
        }
        
    }
}
