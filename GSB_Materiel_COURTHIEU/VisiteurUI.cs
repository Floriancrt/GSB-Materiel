using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GSB_Materiel_LAFAGE
{
    public partial class VisiteurUI : UserControl
    {
        public VisiteurUI()
        {
            InitializeComponent();
        }

        public static void infosVisit(DataGridView infos_visit)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            // Connexion
            String connString = "Server=127.0.0.1;Database=gsb_materiel;Uid=root;Password=;SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            // On récupère le résultat de la requête + on l'intègre dans le DataSet
            adapter.SelectCommand = new MySqlCommand("Select matricule, nom, prenom, date_embauche, mdp, adresse, objectif, avantages, prime, budget from personnel, visiteur where visiteur.id_visit = personnel.matricule", conn);
            adapter.Fill(ds);

            // On relie le résultat à la dataGridView donnée en paramètre
            infos_visit.DataSource = ds.Tables[0];
            infos_visit.DataSource = ds.Tables[0];
            infos_visit.Refresh();
        }
        List<Visiteur> visiteurs;
        BindingSource src;

        private void VisiteurUI_Load(object sender, EventArgs e)
        {

            visiteurs = new List<Visiteur>();
            src = new BindingSource();

            visiteurs = Bd.selectVisit();

            foreach (Visiteur visiteur in visiteurs)
            {
                mod_mat_visit_cbox.Items.Add(visiteur.Matricule);
            }

            foreach (Visiteur visiteur in visiteurs)
            {
                supp_mat_visit_cbox.Items.Add(visiteur.Matricule);
            }

        }

            List<Visiteur> lesVisiteurs;

            BindingSource bindingSource1;

        private void aj_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void actualiser_visit_btn_Click(object sender, EventArgs e)
        {
            infos_visit.DataSource = bindingSource1;
            bindingSource1.DataSource = Bd.selectVisit();
        }


        private void Accueil_Admin_Load(object sender, EventArgs e)
        {


            // Bouton pour actualiser les résultats (techniciens)
            // ComboBox
            lesVisiteurs = Bd.selectVisit();
            //lesTechniciens = Bd.selectTech();
            /*
            foreach(Technicien leTechnicien in lesTechniciens)
            {
                mod_mat_tech_cbox.Items.Add(leTechnicien.Matricule);
            }
            */
            foreach (Visiteur leVisiteur in lesVisiteurs)
            {
                mod_mat_visit_cbox.Items.Add(leVisiteur.Matricule);
            }

            lesVisiteurs = new List<Visiteur>();
            
            bindingSource1 = new BindingSource();
            

        }

    private void mod_visit_btn_Click(object sender, EventArgs e)
        {

            if (mod_mdp_visit_chk.Checked)
            {
                Bd.modifMdpVisiteur(mod_mat_visit_cbox.Text, mod_mdp_visit_txt.Text);
            }

            if (mod_adresse_chk.Checked)
            {
                Bd.modifAdresse(mod_mat_visit_cbox.Text, mod_adresse_txt.Text);
            }

            if (mod_objectif_chk.Checked)
            {
                Bd.modifObjectif(mod_mat_visit_cbox.Text, mod_objectif_txt.Text);
            }

            if (mod_avantages_chk.Checked)
            {
                Bd.modifAvantages(mod_mat_visit_cbox.Text, mod_avantages_txt.Text);
            }
            if (mod_prime_chk.Checked)
            {
                Bd.modifPrime(mod_mat_visit_cbox.Text, mod_prime_txt.Text);
            }
            if (mod_budget_chk.Checked)
            {
                Bd.modifBudget(mod_mat_visit_cbox.Text, mod_budget_txt.Text);
            }






        }

        private void aj_visit_btn_Click(object sender, EventArgs e)
        {


            Visiteur unVisiteur = new Visiteur(aj_mat_visit_txt.Text, aj_nom_visit_txt.Text, aj_prenom_visit_txt.Text, aj_date_visit.Text, aj_mdp_visit_txt.Text, aj_adresse_txt.Text, aj_objectif_txt.Text, aj_avantages_txt.Text, Convert.ToDouble(aj_budget_txt.Text), 0);
            Bd.ajoutVisit(unVisiteur);


        }


        List<Visiteur> listeVisit;

        BindingSource bindingSource;

        private void button1_Click(object sender, EventArgs e)
        {

            listeVisit = new List<Visiteur>();

            bindingSource1 = new BindingSource();

            infos_visit.DataSource = bindingSource1;
            bindingSource1.DataSource = Bd.selectVisit();

        }

        private void technicienUI1_Load(object sender, EventArgs e)
        {

        }

        

        private void mod_mat_visit_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listeVisit = new List<Visiteur>();

            bindingSource1 = new BindingSource();

            infos_visit.DataSource = bindingSource1;
            bindingSource1.DataSource = Bd.selectVisit();
        }

        private void mod_mat_visit_cbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void suppr_visit_btn_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Le matricule " +supp_mat_visit_cbox.Text+ " à été supprimé");
            Bd.supprVisiteur(supp_mat_visit_cbox.Text);

            listeVisit = new List<Visiteur>();

            bindingSource1 = new BindingSource();

            infos_visit.DataSource = bindingSource1;
            bindingSource1.DataSource = Bd.selectVisit();
        }
    }
}
