using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.DAL.Gestionnaire;
using Zoom.Model.Animal;

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

        /**
         * Contructors
         */ 
        public Zoo(string nom, string adresse, string ville, double tarifBillet)
        {
            Nom = nom;
            Adresse = adresse;
            Ville = ville;
            TarifBillet = tarifBillet;
        }

        /**
         * Methods
         */


    }
}
