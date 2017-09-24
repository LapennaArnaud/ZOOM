using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.DAL.Gestionnaire;
using Zoom.Model;
using Zoom.Model.Aliment;
using Zoom.Model.Animal;
using Zoom.Model.Personne;

using Zoom.Model.Structure;

namespace Zoom.BLL.Controleur
{
    public class Zoo 
    {
        /**
         * Props
         */ 
        public string Nom { get; set; }

        public string Adresse { get; set; }

        public string Ville { get; set; }

        public double TarifBillet { get; set; }

        public double Tresorerie { get; set; }

        private static Zoo _instance;
        public Dictionary<AAliment, int> ListeAliment { get; set; }

        public List<Visiteur> ListVisiteur { get; private set; }

        /**
         * Contructors
         */
        private Zoo( string nom, string adresse, string ville, double tarifBillet)
        {

            Nom = nom;
            Adresse = adresse;
            Ville = ville;
            TarifBillet = tarifBillet;
            ListVisiteur = new List<Visiteur>();
            ListeAliment = new Dictionary<AAliment, int>();
        }

        /**
         * Methods
         */
        public override string ToString()
        {
            return string.Format(" Type : {0} Nom : {1} Adresse : {2} \n\r Ville : {3} TarifBillet : {4}", this.GetType().Name, this.Nom, this.Adresse, this.Ville, this.TarifBillet);
        }

        public static Zoo getInstance()
        {
            if (_instance == null)
                _instance = new Zoo("Zoom", "11 rue tracteur", "Paris", 15);

            return _instance;
        }

        

        

    }
}
