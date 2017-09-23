using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.DAL.Gestionnaire;
using Zoom.Model;
using Zoom.Model.Animal;

namespace Zoom.BLL.Controleur
{
    public class Zoo : IEntite
    {
        /**
         * Props
         */ 
        public string Nom { get; set; }

        public string Adresse { get; set; }

        public string Ville { get; set; }

        public double TarifBillet { get; set; }
        public int Id { get ; set ; }

        /**
         * Contructors
         */
        public Zoo(int id, string nom, string adresse, string ville, double tarifBillet)
        {
            Id = id;
            Nom = nom;
            Adresse = adresse;
            Ville = ville;
            TarifBillet = tarifBillet;
        }

        /**
         * Methods
         */
        public override string ToString()
        {
            return string.Format("ID : {0} Type : {1} Nom : {2} Adresse : {3} \n\r Ville : {4} TarifBillet : {5}", this.Id, this.GetType().Name, this.Nom, this.Adresse, this.Ville, this.TarifBillet);
        }

    }
}
