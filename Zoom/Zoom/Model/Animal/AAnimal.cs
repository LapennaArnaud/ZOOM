using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom.BLL.Model.Animal
{
    public abstract class AAnimal : IEntite
    {

        #region Props
        public int Id { get; set; }

        public string Nom { get; set; }

        public DateTime DateNaissance { get; set; }

        public ESexe Sexe { get; set; }

        private static int maturite = 3;

        public abstract int Maturite
        {
            get;
        }
        
        private static int nbPatte = 4;
        #endregion


        #region Constructors
        public AAnimal(int id, string nom, ESexe sexe, DateTime date)
        {
            Id = id;
            DateNaissance = date;
            Sexe = sexe;
            Nom = nom;
        }

        public AAnimal(int id, string nom, ESexe sexe) : this(id, nom, sexe, DateTime.Now)
        {

        }
        #endregion

        #region Methods
        public abstract void Manger();

        // TODO : à faire ici ou au niveau du service ?

        public string Reproduction(AAnimal partenaire)
        {
            return
                (
                    this.MemeEspece(partenaire)
                    && this.Sexe != partenaire.Sexe
                    && this.CalculAge() >= this.Maturite 
                    && partenaire.CalculAge() >= partenaire.Maturite                
                ) 
                ? "Reproduction" : "Impossible";
        }

        // Service
        public int CalculAge()
        {
            return (DateTime.Now.Year - this.DateNaissance.Year);
        }

        public override string ToString()
        {
            string determinant = (this.Sexe == ESexe.Femelle ? "la" : "le");
            return string.Format("{3} {2} {1} {0}", this.GetType().Name, determinant, this.Nom, this.Id);
        }

        //Service
        public bool MemeEspece(Object animal)
        {
            if(this.GetType() == this.GetType())
                return true;
            return false;
        }

        
        #endregion

    }   

}
