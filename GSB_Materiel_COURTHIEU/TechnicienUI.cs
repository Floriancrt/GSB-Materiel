using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_Materiel_LAFAGE
{
    public partial class TechnicienUI : UserControl
    {
        public TechnicienUI()
        {
            InitializeComponent();
        }

        List<Technicien> techniciens;
        BindingSource src;

        private void TechnicienUI_Load(object sender, EventArgs e)
        {

            techniciens = new List<Technicien>();
            src = new BindingSource();

            techniciens = Bd.selectTech();

            foreach (Technicien technicien in techniciens)
            {
                mod_mat_tech_cbox.Items.Add(technicien.Matricule);
            }

            foreach(Technicien technicien in techniciens)
            {
                supp_mat_tech_cbox.Items.Add(technicien.Matricule);
            }

        }

        List<Technicien> lesTechniciens;
        BindingSource bindingSource2;

        private void Accueil_Admin_Load(object sender, EventArgs e)
        {
            // Bouton pour actualiser les résultats (techniciens)
            // ComboBox
            lesTechniciens = Bd.selectTech();
            //lesTechniciens = Bd.selectTech();
            /*
            foreach(Technicien leTechnicien in lesTechniciens)
            {
                mod_mat_tech_cbox.Items.Add(leTechnicien.Matricule);
            }
            */
            foreach (Technicien leTechnicien in lesTechniciens)
            {
                mod_mat_tech_cbox.Items.Add(leTechnicien.Matricule);
            }

            lesTechniciens = new List<Technicien>();

            bindingSource2 = new BindingSource();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Technicien unTechnicien = new Technicien(aj_mat_tech_txt.Text, aj_nom_tech_txt.Text, aj_prenom_tech_txt.Text, aj_date_tech.Text, aj_mdp_tech_txt.Text, aj_formation_txt.Text, aj_intervention_txt.Text, aj_competences_txt.Text);
            Bd.ajoutTech(unTechnicien);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Bd.supprPersonnel(supp_mat_visit_cbox.Text);
        }
        
        // Supprimer un technicien
        private void supp_tech_btn_Click(object sender, EventArgs e)
        {
            Bd.supprTechnicien(supp_mat_tech_cbox.Text);
        }

        private void actualiser_tech_btn_Click(object sender, EventArgs e)
        {
            infos_tech.DataSource = bindingSource2;
            bindingSource2.DataSource = Bd.selectTech();
        }

        private void infos_tech_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        List<Technicien> listeTech;

        BindingSource bindingSource1;



        private void button1_Click_2(object sender, EventArgs e)
        {
            listeTech = new List<Technicien>();

            bindingSource1 = new BindingSource();

            infos_tech.DataSource = bindingSource1;
            bindingSource1.DataSource = Bd.selectTech();
        }

        private void aj_tech_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le technicien " + aj_nom_tech_txt.Text + " vient d'être crée");
            Technicien unTechnicien = new Technicien(aj_mat_tech_txt.Text, aj_nom_tech_txt.Text, aj_prenom_tech_txt.Text, aj_date_tech.Text, aj_mdp_tech_txt.Text, aj_formation_txt.Text, aj_intervention_txt.Text, aj_competences_txt.Text);

            Bd.ajoutTech(unTechnicien);
            

            listeTech = new List<Technicien>();

            bindingSource1 = new BindingSource();

            infos_tech.DataSource = bindingSource1;
            bindingSource1.DataSource = Bd.selectTech();


        }

        private void supp_tech_btn_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Le matricule " + supp_mat_tech_cbox.Text + " à été supprimé");
            Bd.supprTechnicien(supp_mat_tech_cbox.Text);

            listeTech = new List<Technicien>();

            bindingSource1 = new BindingSource();

            infos_tech.DataSource = bindingSource1;
            bindingSource1.DataSource = Bd.selectTech();
        }
    }
}
