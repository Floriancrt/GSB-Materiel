using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Materiel_LAFAGE
{
    class Visiteur : Personnel
    {
        private String adresse;
        private String objectif;
        private String avantages;
        private double prime;
        private double budget;

        public string Adresse { get => adresse; set => adresse = value; }
        public string Objectif { get => objectif; set => objectif = value; }
        public string Avantages { get => avantages; set => avantages = value; }
        public double Prime { get => prime; set => prime = value; }
        public double Budget { get => budget; set => budget = value; }

        public Visiteur(String unMatricule, String unNom, String unPrenom, String uneDateEmbauche, String unMdp, String uneAdresse, 
            String unObjectif, String desAvantages, Double unBudget, Double unePrime) :base(unMatricule, unNom, unPrenom, uneDateEmbauche, unMdp)
        {
            adresse = uneAdresse;
            objectif = unObjectif;
            avantages = desAvantages;  
            budget = unBudget;
            prime = unePrime;
        }

    }
}
