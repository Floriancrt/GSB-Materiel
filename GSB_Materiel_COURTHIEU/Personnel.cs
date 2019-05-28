using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GSB_Materiel_LAFAGE
{
    class Personnel
    {
        private String matricule;
        private String nom;
        private String prenom;
        private String dateEmbauche;
        private String mdp;

        public Personnel(String unMatricule, String unNom, String unPrenom, String uneDateEmbauche, String unMdp)
        {
            Matricule = unMatricule;
            Nom = unNom;
            Prenom = unPrenom;
            DateEmbauche = uneDateEmbauche;
            Mdp = unMdp;
        }


        public string Matricule { get => matricule; set => matricule = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string DateEmbauche { get => dateEmbauche; set => dateEmbauche = value; }
        public string Mdp { get => mdp; set => mdp = value; }
    }
}
