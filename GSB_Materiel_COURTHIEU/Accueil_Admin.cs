using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_Materiel_LAFAGE
{
    public partial class Accueil_Admin : Form
    {
        public Accueil_Admin()
        {
            InitializeComponent();
            panel6.Height = button1.Height;
            panel6.Top = button1.Top;
            visiteurUI1.BringToFront();
        }

        List<Visiteur> visiteurs;
        BindingSource src;

        private void Accueil_Admin_Load(object sender, EventArgs e)
        {

          

        }
        /*
        // Ajouter un visiteur
        private void aj_btn_Click(object sender, EventArgs e)
        {
            Visiteur unVisiteur = new Visiteur(aj_mat_visit_txt.Text, aj_nom_visit_txt.Text, aj_prenom_visit_txt.Text, aj_date_visit.Text, aj_mdp_visit_txt.Text, aj_adresse_txt.Text, aj_objectif_txt.Text, aj_avantages_txt.Text, Convert.ToDouble(aj_budget_txt.Text), 0);
            Bd.ajoutVisit(unVisiteur);
        }

        /*
        // Ajouter un technicien
        private void button1_Click(object sender, EventArgs e)
        {
            Technicien unTechnicien = new Technicien(aj_mat_tech_txt.Text, aj_nom_tech_txt.Text, aj_prenom_tech_txt.Text, aj_date_tech.Text, aj_mdp_tech_txt.Text, aj_formation_txt.Text, aj_intervention_txt.Text, aj_competences_txt.Text);
            Bd.ajoutTech(unTechnicien);

        }
        */
        // Supprimer un technicien
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Bd.supprPersonnel(supp_mat_visit_cbox.Text);
        }
        /*
        // Supprimer un technicien
        private void supp_tech_btn_Click(object sender, EventArgs e)
        {
            Bd.supprPersonnel(supp_mat_tech_cbox.Text);
        }
        */
        // Modifier un visiteur 
        /* private void mod_visit_btn_Click(object sender, EventArgs e)
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
         */
        // Bouton pour actualiser les résultats (visiteurs)
        private void actualiser_visit_btn_Click(object sender, EventArgs e)
        {
            //infos_visit.DataSource = bindingSource1;
            //bindingSource1.DataSource = Bd.selectVisit();
        }
        /*
        // Bouton pour actualiser les résultats (techniciens)
        private void actualiser_tech_btn_Click(object sender, EventArgs e)
        {
            infos_tech.DataSource = bindingSource2;
            bindingSource2.DataSource = Bd.selectTech();
        }
        */
        private void personnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Demande_Fenetre fenetre = new Demande_Fenetre();
            this.Close();
            fenetre.Show();
        }

        private void actualiser_tech_btn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel6.Height = button1.Height;
            panel6.Top = button1.Top;
            visiteurUI1.BringToFront();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            panel6.Height = button3.Height;
            panel6.Top = button3.Top;
            demandeUI1.BringToFront();
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            panel6.Height = button2.Height;
            panel6.Top = button2.Top;
            technicienUI1.BringToFront();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel6.Height = button4.Height;
            panel6.Top = button4.Top;
        }

        private void technicienUI1_Load(object sender, EventArgs e)
        {

        }

        private void technicienUI1_Load_1(object sender, EventArgs e)
        {

        }

        private void demandeUI1_Load(object sender, EventArgs e)
        {

        }
    }
}
