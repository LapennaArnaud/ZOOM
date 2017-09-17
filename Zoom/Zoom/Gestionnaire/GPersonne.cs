using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.BLL.Model;
using Zoom.BLL.Model.Personne;

namespace Zoom.BLL.Gestionnaire
{
    public class GPersonne
    {
        private static int id = 0;

        private static List<APersonne> ListPersonne { get; set; } = new List<APersonne>();

        public static APersonne AddVisiteur(string nom, string prenom, ESexe sexe, ECategorieBillet categorieBillet)
        {
            APersonne p = new Visiteur(AssigneID(), nom, prenom, sexe, categorieBillet);
            ListPersonne.Add(p);
            return p;
        }

        public static APersonne AddSecurite(string nom, string prenom, ESexe sexe, DateTime dateNaissance)
        {
            APersonne p = new Securite(AssigneID(), nom, prenom, sexe, dateNaissance);
            ListPersonne.Add(p);
            return p;
        }

        public static APersonne AddManager(string nom, string prenom, ESexe sexe, DateTime dateNaissance)
        {
            APersonne p = new Manager(AssigneID(), nom, prenom, sexe, dateNaissance);
            ListPersonne.Add(p);
            return p;
        }

        public static APersonne AddAnimateur(string nom, string prenom, ESexe sexe, DateTime dateNaissance)
        {
            APersonne p = new Animateur(AssigneID(), nom, prenom, sexe, dateNaissance);
            ListPersonne.Add(p);
            return p;
        }

        public static APersonne AddVeterinaire(string nom, string prenom, ESexe sexe, DateTime dateNaissance)
        {
            APersonne p = new Veterinaire(AssigneID(), nom, prenom, sexe, dateNaissance);
            ListPersonne.Add(p);
            return p;
        }

        public static void RemovePersonne(APersonne p)
        {
            ListPersonne.Remove(p);
        }

        public static string AfficherAll()
        {
            string description = "";
            foreach (APersonne p in ListPersonne)
            {
                description += p.ToString() + "\n";
            }
            return description;
        }

        public static int AssigneID()
        {
            var idOld = id;
            id++;
            return idOld;
        }
    }
}
