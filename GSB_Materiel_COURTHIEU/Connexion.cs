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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }


        private void Connexion_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Voulez-vous quitter l'application ?", "Fermeture", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
                else if (dialog == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            catch
            {

                MessageBox.Show("");


            }
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            date_lbl.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");
        }

        private void connexion_btn_Click(object sender, EventArgs e)
        {

            
                if (admin_rbtn.Checked)
                {
                    Fenetre.connexionAdmin(id_txt.Text, mdp_txt.Text);
                }

                else if (visit_rbtn.Checked)
                {
                    Fenetre.connexionVisiteur(id_txt.Text, mdp_txt.Text);
                }

                else if (tech_rbtn.Checked)
                {
                    Fenetre.connexionTechnicien(id_txt.Text, mdp_txt.Text);
                }

            

            


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void date_lbl_Click(object sender, EventArgs e)
        {

        }

        private void id_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
