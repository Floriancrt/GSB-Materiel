using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace GSB_Materiel_LAFAGE
{

    class Bd
    {
        // Ajouter un personnel de type visiteur
        public static void ajoutVisit(Visiteur unVisiteur)
        {
            // Connexion
            String connString = "Server = 127.0.0.1;Database = gsb_materiel;Uid = root;Password = ;SslMode = none";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            // Requête d'insertion d'un personnel
            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "Insert into personnel(matricule, nom, prenom, date_embauche, mdp) values(@matricule, @nom, @prenom, @date_embauche, @mdp)";
            cmd1.Parameters.AddWithValue("@matricule", unVisiteur.Matricule);
            cmd1.Parameters.AddWithValue("@nom", unVisiteur.Nom);
            cmd1.Parameters.AddWithValue("@prenom", unVisiteur.Prenom);
            cmd1.Parameters.AddWithValue("@date_embauche", unVisiteur.DateEmbauche);
            cmd1.Parameters.AddWithValue("@mdp", unVisiteur.Mdp);
            cmd1.ExecuteNonQuery();
            cmd1.Parameters.Clear();

            // Requête d'insertion d'un visiteur
            MySqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandText = "Insert into visiteur(adresse, objectif, avantages, prime, budget, id_visit) values(@adresse, @objectif, @avantages, @prime, @budget, @id_visit )";
            cmd2.Parameters.AddWithValue("@adresse", unVisiteur.Adresse);
            cmd2.Parameters.AddWithValue("@objectif", unVisiteur.Objectif);
            cmd2.Parameters.AddWithValue("@avantages", unVisiteur.Avantages);
            cmd2.Parameters.AddWithValue("@prime", unVisiteur.Prime);
            cmd2.Parameters.AddWithValue("@budget", unVisiteur.Budget);
            cmd2.Parameters.AddWithValue("@id_visit", unVisiteur.Matricule);
            cmd2.ExecuteNonQuery();
            cmd2.Parameters.Clear();
        }

        // Ajouter un personnel de type technicien
        public static void ajoutTech(Technicien unTechnicien)
        {
            // Connexion
            String connString = "Server = 127.0.0.1;Database = gsb_materiel;Uid = root;Password = ;SslMode = none";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            // Requête d'insertion d'un personnel
            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "Insert into personnel(matricule, nom, prenom, date_embauche, mdp) values(@matricule, @nom, @prenom, @date_embauche, @mdp)";
            cmd1.Parameters.AddWithValue("@matricule", unTechnicien.Matricule);
            cmd1.Parameters.AddWithValue("@nom", unTechnicien.Nom);
            cmd1.Parameters.AddWithValue("@prenom", unTechnicien.Prenom);
            cmd1.Parameters.AddWithValue("@date_embauche", unTechnicien.DateEmbauche);
            cmd1.Parameters.AddWithValue("@mdp", unTechnicien.Mdp);
            cmd1.ExecuteNonQuery();
            cmd1.Parameters.Clear();

            // Requête d'insertion d'un technicien
            MySqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandText = "Insert into technicien(formation, intervention, competences, id_tech) values(@formation, @intervention, @competences, @id_tech)";
            cmd2.Parameters.AddWithValue("@formation", unTechnicien.Formation);
            cmd2.Parameters.AddWithValue("@intervention", unTechnicien.Intervention);
            cmd2.Parameters.AddWithValue("@competences", unTechnicien.Competences);
            cmd2.Parameters.AddWithValue("@id_tech", unTechnicien.Matricule);
            cmd2.ExecuteNonQuery();
            cmd2.Parameters.Clear();
        }
        
        // Consulter les informations d'un visiteur
        public static void infosVisit(DataGridView dataGridView1)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            // Connexion
            String connString = "Server=127.0.0.1;Database=gsb_materiel;Uid=root;Password=;SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            // On récupère le résultat de la requête + on l'intègre dans le DataSet
            adapter.SelectCommand = new MySqlCommand("CALL infos_visit();", conn);
            adapter.Fill(ds);

            // On relie le résultat à la dataGridView donnée en paramètre
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
        }

        // Consulter les informations d'un technicien
        public static void infosTech(DataGridView dataGridView1)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            // Connexion
            String connString = "Server=127.0.0.1;Database=gsb_materiel;Uid=root;Password=;SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            // On récupère le résultat de la requête + on l'intègre dans le DataSet
            adapter.SelectCommand = new MySqlCommand("CALL infos_tech();", conn);
            adapter.Fill(ds);

            // On relie le résultat à la dataGridView donnée en paramètre
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
        }
        

            public static List<Visiteur> selectVisit()
        {
            List <Visiteur> lesVisiteurs = new List<Visiteur>();
            // Connexion
            String connString = "Server=127.0.0.1;Database=gsb_materiel;Uid=root;Password=;SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "Select matricule, nom, prenom, date_embauche, mdp, adresse, objectif, avantages, prime, budget from personnel," +
                " visiteur where visiteur.id_visit = personnel.matricule";

            MySqlDataReader dataReader = cmd1.ExecuteReader();
            while (dataReader.Read())
            {
                Visiteur unVisiteur = new Visiteur(Convert.ToString(dataReader["matricule"]), Convert.ToString(dataReader["nom"]), Convert.ToString(dataReader["prenom"]),
                    Convert.ToString(dataReader["date_embauche"]), Convert.ToString(dataReader["mdp"]), Convert.ToString(dataReader["adresse"]), 
                    Convert.ToString(dataReader["objectif"]), Convert.ToString(dataReader["avantages"]), Convert.ToDouble(dataReader["prime"]), Convert.ToDouble(dataReader["budget"]));
                lesVisiteurs.Add(unVisiteur);
            }
            conn.Close();
            return lesVisiteurs;
        }

        public static List<Technicien> selectTech()
        {
            List<Technicien> lesTechniciens = new List<Technicien>();
            // Connexion
            String connString = "Server=127.0.0.1;Database=gsb_materiel;Uid=root;Password=;SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "CALL select_visit();";

            MySqlDataReader dataReader = cmd1.ExecuteReader();
            while (dataReader.Read())
            {
                Technicien unTechnicien = new Technicien(Convert.ToString(dataReader["matricule"]), Convert.ToString(dataReader["nom"]), Convert.ToString(dataReader["prenom"]),
                    Convert.ToString(dataReader["date_embauche"]), Convert.ToString(dataReader["mdp"]), Convert.ToString(dataReader["formation"]),
                    Convert.ToString(dataReader["intervention"]), Convert.ToString(dataReader["competences"]));
                    lesTechniciens.Add(unTechnicien);               
            }
            conn.Close();
            return lesTechniciens;
        }


            
        // Liste des visiteurs dans une ComboBox
        public static void listeVisit(ComboBox comboBox1)
        {
            // Connexion
            String connString = "Server = 127.0.0.1;Database = gsb_materiel;Uid = root;Password = ;SslMode = none";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "Select id_visit from visiteur";
            MySqlDataReader dataReader = cmd1.ExecuteReader();
            while (dataReader.Read())
            {
                comboBox1.Items.Add(dataReader["id_visit"]);
            }
                       
        }
        /*
        // Liste des techniciens dans une ComboBox
        public static void listeTech(ComboBox comboBox1)
        {
            // Connexion
            String connString = "Server = 127.0.0.1;Database = gsb_materiel;Uid = root;Password = ;SslMode = none";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "Select id_tech from technicien";
            MySqlDataReader dataReader = cmd1.ExecuteReader();
            while (dataReader.Read())
            {
                comboBox1.Items.Add(dataReader["id_tech"]);
            }
        }
        */
        public static void supprVisiteur(String matricule)
        {
            // Connexion
            String connString = "Server = 127.0.0.1;Database = gsb_materiel;Uid = root;Password = ;SslMode = none";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            // Supprimer un visiteur
            MySqlCommand cmd1 = conn.CreateCommand();
           
            cmd1.CommandText = @"DELETE FROM visiteur WHERE id_visit = @matricule";
            cmd1.Parameters.AddWithValue("@matricule", matricule);

            cmd1.ExecuteNonQuery();
            conn.Close();
        }

        public static void supprTechnicien(String matricule)
        {
            // Connexion
            String connString = "Server = 127.0.0.1;Database = gsb_materiel;Uid = root;Password = ;SslMode = none";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            // Supprimer un technicien
            MySqlCommand cmd1 = conn.CreateCommand();

            cmd1.CommandText = @"DELETE FROM technicien WHERE id_tech = @matricule";
            cmd1.Parameters.AddWithValue("@matricule", matricule);

            cmd1.ExecuteNonQuery();
            conn.Close();


        }

        // Modifier un visiteur

        public static void modifMdpVisiteur(String matriculeValue, String mdpValue)
        {
            // Connexion
            String connString = "Server = 127.0.0.1;Database = gsb_materiel;Uid = root;Password = ;SslMode = none";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "Update personnel set mdp = '" + mdpValue + "'where matricule = '" + matriculeValue + "'";
            cmd1.ExecuteNonQuery();
            cmd1.Parameters.Clear();
        }

        public static void modifAdresse(String matriculeValue, String adresseValue)
        {
            // Connexion
            String connString = "Server = 127.0.0.1;Database = gsb_materiel;Uid = root;Password = ;SslMode = none";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "Update visiteur set adresse = '" + adresseValue + "'where id_visit = '" + matriculeValue + "'";
            cmd1.ExecuteNonQuery();
            cmd1.Parameters.Clear();
        }

        public static void modifObjectif(String matriculeValue, String objectifValue)
        {
            // Connexion
            String connString = "Server = 127.0.0.1;Database = gsb_materiel;Uid = root;Password = ;SslMode = none";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "Update visiteur set objectif = '" + objectifValue + "'where id_visit = '" + matriculeValue + "'";
            cmd1.ExecuteNonQuery();
            cmd1.Parameters.Clear();
        }

        public static void modifAvantages(String matriculeValue, String avantagesValue)
        {
            // Connexion
            String connString = "Server = 127.0.0.1;Database = gsb_materiel;Uid = root;Password = ;SslMode = none";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "Update visiteur set avantages = '" + avantagesValue + "'where id_visit = '" + matriculeValue + "'";
            cmd1.ExecuteNonQuery();
            cmd1.Parameters.Clear();
        }

        public static void modifPrime(String matriculeValue, String primeValue)
        {
            // Connexion
            String connString = "Server = 127.0.0.1;Database = gsb_materiel;Uid = root;Password = ;SslMode = none";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "Update visiteur set prime = '" + primeValue + "'where id_visit = '" + matriculeValue + "'";
            cmd1.ExecuteNonQuery();
            cmd1.Parameters.Clear();
        }

        public static void modifBudget(String matriculeValue, String budgetValue)
        {
            // Connexion
            String connString = "Server = 127.0.0.1;Database = gsb_materiel;Uid = root;Password = ;SslMode = none";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "Update visiteur set budget = '" + budgetValue + "'where id_visit = '" + matriculeValue + "'";
            cmd1.ExecuteNonQuery();
            cmd1.Parameters.Clear();
        }

        public static void ajouterDemande(Demande uneDemande)
        {
            // Connexion
            String connString = "Server = 127.0.0.1;Database = gsb_materiel;Uid = root;Password = ;SslMode = none";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            //Requête d'insertion d'une demande
            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "Insert into demande(ticket, materiel, objet, urgence, intervention) values(@ticket, @materiel, @objet, @urgence, @intervention)";
            cmd1.Parameters.AddWithValue("@ticket", uneDemande.Ticket);
            cmd1.Parameters.AddWithValue("@materiel", uneDemande.Materiel);
            cmd1.Parameters.AddWithValue("@objet", uneDemande.Objet);
            cmd1.Parameters.AddWithValue("@urgence", uneDemande.Urgence);
            cmd1.Parameters.AddWithValue("@intervention", uneDemande.Intervention);
            cmd1.ExecuteNonQuery();
            cmd1.Parameters.Clear();


        }



    }





    }
