using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Materiel_LAFAGE
{
    class Demande
    {
        private String ticket;
        private String materiel;
        private String objet;
        private String urgence;
        private String etat;
        private String intervention;
        private DateTime heure_debut;
        private DateTime heure_fin;
        private String travail;
        private String technicien_demande;

        public string Ticket { get => ticket; set => ticket = value; }
        public string Materiel { get => materiel; set => materiel = value; }
        public string Objet { get => objet; set => objet = value; }
        public string Urgence { get => urgence; set => urgence = value; }
        public string Etat { get => etat; set => etat = value; }
        public string Intervention { get => intervention; set => intervention = value; }
        public DateTime Heure_debut { get => heure_debut; set => heure_debut = value; }
        public DateTime Heure_fin { get => heure_fin; set => heure_fin = value; }
        public string Travail { get => travail; set => travail = value; }
        public string Technicien_demande { get => technicien_demande; set => technicien_demande = value; }

        


        public Demande(String UnTicket, String UnMateriel, String UnObjet, String UneUrgence, String UnEtat, String UneIntervention, DateTime UneHeure_debut, DateTime UneHeure_fin, String UnTravail, String UnTechnicien_demande)
        {
            ticket = UnTicket;
            materiel = UnMateriel;
            objet = UnObjet;
            urgence = UneUrgence;
            etat = UnEtat;
            intervention = UneIntervention;
            heure_debut = UneHeure_debut;
            heure_fin = UneHeure_fin;
            technicien_demande = UnTechnicien_demande;

        }





    }
}
