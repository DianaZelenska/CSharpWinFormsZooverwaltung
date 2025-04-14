
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace Zoo
{
    public class Datenbank
    {
        private MySqlConnection con;
        private string connectionString;

        // Verbindung mit DB erstellen
        public Datenbank()
        {
            connectionString = 
                string.Format("SERVER=localhost;DATABASE=zoo;UID=root;PASSWORD='';");
            con = new MySqlConnection(connectionString);
        }



        // Liste für Tabelle Kontinent
        public List<Kontinent> getKontinente()
        {
            List<Kontinent> liko = new List<Kontinent>();
            oeffnen();
            try
            {
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT KontinentID, Name FROM kontinent;";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liko.Add(
                        new Kontinent(
                            reader.GetInt32("KontinentID"),
                            reader.GetString("Name")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            schliessen();
            return liko;
        }

        // Anweisung für Delete
        public void delKontinent(int id)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = string.Format("DELETE FROM kontinent WHERE KontinentID = {0};", id.ToString());
            com.ExecuteNonQuery();
            schliessen();
        }

        // Anweisung für Insert oder Update
        public void neuKontinent(Kontinent ko)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            //com.CommandText = "INSERT INTO kontinent VALUES(NULL, '" + ko.Name1 + "');";
            if (ko.KontinentID1 == -1)
                com.CommandText = string.Format("INSERT INTO kontinent VALUES(NULL, '{0}');", ko.Name1);
            else
                com.CommandText = string.Format("UPDATE kontinent SET Name = '{0}' " + "WHERE KontinentID = {1}", ko.Name1, ko.KontinentID1);

            com.ExecuteNonQuery();
            schliessen();
        }



        public List<Tierart> getTierarten()
        {
            List<Tierart> liti = new List<Tierart>();
            oeffnen();
            try
            {
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT TierartID, Name FROM tierart;";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liti.Add(
                        new Tierart(
                            reader.GetInt32("TierartID"),
                            reader.GetString("Name")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            schliessen();
            return liti;
        }

        public void neuTierart(Tierart ti)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            //com.CommandText = "INSERT INTO kontinent VALUES(NULL, '" + ko.Name1 + "');";
            if (ti.TierartID1 == -1)
                com.CommandText = string.Format("INSERT INTO tierart VALUES(NULL, '{0}');", ti.TierartName1);
            else
                com.CommandText = string.Format("UPDATE tierart SET Name = '{0}' " + "WHERE TierartID = {1}", ti.TierartName1, ti.TierartID1);

            com.ExecuteNonQuery();
            schliessen();
        }

        public void delTierart(int id)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = string.Format("DELETE FROM tierart WHERE TierartID = {0};", id.ToString());
            com.ExecuteNonQuery();
            schliessen();
        }

        // Methode zum Zählen von Anzahl der Datensätze in Tabelle tierart
        public int getAnzahlTierarten()
        {
            int anzahl = 0;
            oeffnen();
            try
            {
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT COUNT(*) FROM tierart;";
                anzahl = Convert.ToInt32(com.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
            schliessen();
            return anzahl;
        }



        public List<Gehege> getGehege()
        {
            List<Gehege> lige = new List<Gehege>();
            oeffnen();
            try
            {
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT GehegeID, Name, KontinentID FROM gehege;";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    lige.Add(
                        new Gehege(
                            reader.GetInt32("GehegeID"),
                            reader.GetString("Name"),
                            reader.GetInt32("KontinentID")
                        )
                    );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            schliessen();
            return lige;
        }

        public void neuGehege(Gehege ge)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = string.Format("INSERT INTO gehege (Name, KontinentID) VALUES ('{0}', {1});", ge.GehegeName, ge.GehegeKontinent);
            com.ExecuteNonQuery();
            schliessen();
        }

        public void delGehege(int id)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = string.Format("DELETE FROM gehege WHERE GehegeID = {0};", id.ToString());
            com.ExecuteNonQuery();
            schliessen();
        }



        public List<Tier> getTiere()
        {
            List<Tier> litiere = new List<Tier>();
            oeffnen();
            try
            {
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT TierID, Name, Geburtsjahr, GehegeID, TierartID FROM tier;";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    litiere.Add(
                        new Tier(
                            reader.GetInt32("TierID"),
                            reader.GetString("Name"),
                            reader.GetString("Geburtsjahr"),
                            reader.GetInt32("GehegeID"),
                            reader.GetInt32("TierartID")
                        )
                    );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            schliessen();
            return litiere;
        }

        public void neuTier(Tier t)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = string.Format("INSERT INTO tier (Name, Geburtsjahr, GehegeID, TierartID) VALUES ('{0}', '{1}', {2}, {3});", t.TierName, t.TierGeburtsjahr, t.TierGehege, t.TierTierart);

            com.ExecuteNonQuery();
            schliessen();
        }

        public void delTier(int id)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = string.Format("DELETE FROM tier WHERE TierID = {0};", id.ToString());
            com.ExecuteNonQuery();
            schliessen();
        }


        // Liste für Select mit Gehege und Tiere
        public List<(string Gehege, string Tier)> getGehegeMitTiere()
        {
            List<(string Gehege, string Tier)> ligeti = new List<(string, string)>();
            oeffnen();
            try
            {
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT gehege.Name AS Gehege, tier.Name AS Tier FROM gehege, tier " + "WHERE gehege.GehegeID = tier.GehegeID;";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    ligeti.Add(
                        (
                            reader.GetString("Gehege"),
                            reader.GetString("Tier")
                        )
                    );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            schliessen();
            return ligeti;
        }


        public List<Pfleger> getPfleger()
        {
            List<Pfleger> lipfl = new List<Pfleger>();
            oeffnen();
            try
            {
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT PflegerID, Vorname, Nachname FROM pfleger";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    lipfl.Add(
                        new Pfleger(
                        reader.GetInt32("PflegerID"),
                        reader.GetString("Vorname"),
                        reader.GetString("Nachname")
                        )
                    );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            schliessen();
            return lipfl;
        }

        public void neuPfleger(Pfleger pfl)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            if (pfl.PflegerID == -1)
                com.CommandText = string.Format("INSERT INTO pfleger VALUES(NULL, '{0}', '{1}');", pfl.PflegerVorname, pfl.PflegerNachname);
            else
                com.CommandText = string.Format("UPDATE pfleger SET Vorname = '{0}', Nachname = '{1}' WHERE PflegerID = {2};", pfl.PflegerVorname, pfl.PflegerNachname, pfl.PflegerID);
            com.ExecuteNonQuery();
            schliessen();
        }

        public void delPfleger(int id)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = string.Format("DELETE FROM pfleger WHERE PflegerID = {0};", id.ToString());
            com.ExecuteNonQuery();
            schliessen();
        }

        
        // Liste für die Beziehungstabelle Gehege und Pfleger
        public List<Gehege_Pfleger> getGehegePfleger()
        {
            List<Gehege_Pfleger> liGePfl = new List<Gehege_Pfleger>();
            oeffnen();
            try
            {
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT GPID, GehegeID, PflegerID, Hauptpfleger FROM gehege_pfleger;";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liGePfl.Add(
                        new Gehege_Pfleger(
                            reader.GetInt32("GPID"),
                            reader.GetInt32("GehegeID"),
                            reader.GetInt32("PflegerID"),
                            reader.GetInt32("Hauptpfleger")
                            )
                        ); 
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
            schliessen();
            return liGePfl;
        }

        public void neuGehegePfleger(Gehege_Pfleger gepfl)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = string.Format("INSERT INTO gehege_pfleger VALUES(NULL, {0}, {1}, {2});", gepfl.Gehegeid, gepfl.Pflegerid, gepfl.Hauptpfleger);
            com.ExecuteNonQuery();
            schliessen();
        }

        public void delGehegePfleger(int id)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = string.Format("DELETE FROM gehege_pfleger WHERE GPID = {0};", id.ToString());
            com.ExecuteNonQuery();
            schliessen();
        }

        // Verbindung öffnen
        private void oeffnen()
        {
            try
            {
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Verbindung schließen
        private void schliessen()
        {
            if (con != null) 
                con.Close();
        }
    }
}
