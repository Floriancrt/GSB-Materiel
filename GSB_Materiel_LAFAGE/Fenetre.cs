using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace GSB_Materiel_LAFAGE
{
    class Fenetre
    {
        public static void connexionAdmin(String textBox1, String textBox2)
        {
            // Connexion
            String connString = "Server = 127.0.0.1;Database = gsb_materiel;Uid = root;Password = ;SslMode = none";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            try
            {
                MySqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandText = "Select * from administrateur where id_admin = '" + textBox1 + "'and mdp_admin = '" + textBox2 + "'";
                MySqlDataReader dataReader = cmd1.ExecuteReader();

                int count = 0;
                while (dataReader.Read())
                {
                    count++;
                }

                if (count == 1)
                {
                    MessageBox.Show("Accès autorisé", "Administrateur", MessageBoxButtons.OK);
                    Accueil_Admin fen = new Accueil_Admin();
                    fen.TopMost = true;
                    fen.Show();
                }

                else if (count ==0)
                {
                    MessageBox.Show("Identifiant ou mot de passe éronné");

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void connexionTechnicien(String textBox1, String textBox2)
        {
            // Connexion
            String connString = "Server = 127.0.0.1;Database = gsb_materiel;Uid = root;Password = ;SslMode = none";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            try
            {
                MySqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandText = "Select id_tech, mdp from technicien, personnel where technicien.id_tech = personnel.matricule and id_tech = '" + textBox1 + "'and mdp = '" + textBox2 + "'";
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                int count = 0;
                while (dataReader.Read())
                {
                    count++;
                }

                if (count == 1)
                {
                    MessageBox.Show("Accès autorisé", "Technicien", MessageBoxButtons.OK);
                    Accueil_Tech fen = new Accueil_Tech();
                    fen.TopMost = true;
                    fen.Show();
                    
                }
                else if (count == 0)
                {
                    MessageBox.Show("Identifiant ou mot de passe éronné");

                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void connexionVisiteur(String textBox1, String textBox2)
        {
            // Connexion
            String connString = "Server = 127.0.0.1;Database = gsb_materiel;Uid = root;Password = ;SslMode = none";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            try
            {
                MySqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandText = "Select id_visit, mdp from visiteur, personnel where visiteur.id_visit = personnel.matricule and id_visit = '" + textBox1 + "'and mdp = '" + textBox2 + "'";
                MySqlDataReader dataReader = cmd1.ExecuteReader();
                int count = 0;
                while (dataReader.Read())
                {
                    count++;
                }

                if (count == 1)
                {
                    MessageBox.Show("Accès autorisé", "Visiteur", MessageBoxButtons.OK);
                    Accueil_Visit fen = new Accueil_Visit();
                    fen.TopMost = true;
                    fen.Show();

                }
                else if (count == 0)
                {
                    MessageBox.Show("Identifiant ou mot de passe éronné");

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
