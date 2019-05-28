using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Materiel_LAFAGE
{
    class Technicien : Personnel
    {
        private String formation;
        private String intervention;
        private String competences;

        public Technicien(String unMatricule, String unNom, String unPrenom, String uneDateEmbauche, String unMdp, String uneFormation, String uneIntervention, 
            String desCompetences) :base(unMatricule, unNom, unPrenom, uneDateEmbauche, unMdp)
        {
            Formation = uneFormation;
            Intervention = uneIntervention;
            Competences = desCompetences;
        }

        public string Formation { get => formation; set => formation = value; }
        public string Intervention { get => intervention; set => intervention = value; }
        public string Competences { get => competences; set => competences = value; }
    }
}
