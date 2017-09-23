using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.Model.Aliment;

namespace Zoom.Model.Animal
{
    public abstract class AAnimal : IEntite
    {

        public enum EEtatFaim { Affame, Faim, Bon, Repu }
        public enum EEtatSante { Agonisant, Blesse, Bien }
        public enum ESexe { Male, Femelle }

        #region Props
        public int Id { get; set; }

        public string Nom { get; set; }

        public DateTime DateNaissance { get; set; }

        public ESexe Sexe { get; set; }

        public abstract int Maturite { get; set; }

        public abstract int NbPatte { get; set; }

        public int Faim { get; set; }

        public int Vie { get; set; }

        public AAnimal Pere { get; set; }

        public AAnimal Mere { get; set; }
        #endregion


        #region Constructors
        public AAnimal(int id, string nom, ESexe sexe, DateTime date)
        {
            Id = id;
            DateNaissance = date;
            Sexe = sexe;
            Nom = nom;
            Faim = 100;
            Vie = 100;
        }

        public AAnimal(int id, string nom, ESexe sexe) : this(id, nom, sexe, DateTime.Now)
        {

        }

        public AAnimal(int id, string nom, ESexe sexe, DateTime date, AAnimal pere, AAnimal mere) : this(id, nom, sexe, date)
        {
            Pere = pere;
            Mere = mere;
        }

        public AAnimal(int id, string nom, ESexe sexe, AAnimal pere, AAnimal mere) : this(id, nom, sexe, DateTime.Now, pere, mere)
        {

        }
        
        #endregion

        #region Methods


        public override string ToString()
        {
            string determinant = (this.Sexe == ESexe.Femelle ? "la" : "le");
            return string.Format("ID : {0} Type : {1} Nom : {2} Sexe : {3} \n\r Age Maturité : {4} Nb Patte : {5}", this.Id, this.GetType().Name, this.Nom, this.Sexe, this.Maturite, this.NbPatte );
        }

        #endregion

    }   

}
