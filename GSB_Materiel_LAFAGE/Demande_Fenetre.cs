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
    public partial class Demande_Fenetre : Form
    {
        public Demande_Fenetre()
        {
            InitializeComponent();
        }

        List<Technicien> lesTechniciens;

        private void Demande_Fenetre_Load(object sender, EventArgs e)
        {
            lesTechniciens = Bd.selectTech();

            foreach (Technicien leTechnicien in lesTechniciens)
            {
                //demande_technicien_cbox.Items.Add(leTechnicien.Matricule);
            }
        }

        // Nouvelle demande
      /*  private void ajouter_demande_btn_Click(object sender, EventArgs e)
        {
            Demande uneDemande = new Demande(demande_ticket_txt.Text, demande_materiel_txt.Text, demande_objet_txt.Text, demande_urgence_txt.Text, demande_intervention_txt.Text);

        }

        */

    }
}
