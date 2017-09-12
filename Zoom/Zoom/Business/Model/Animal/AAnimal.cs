using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom.Business.Model.Animal
{
    public abstract class AAnimal
    {
        internal static int id = 0;

        public int Id { get; private set; }

        public string Nom { get; private set; }

        public DateTime DateNaissance { get; private set; }

        public Sexe Sexe { get; private set; }

        public AAnimal(string nom, Sexe sexe, DateTime date)
        {
            Id = ++id;
            DateNaissance = date;
            Sexe = sexe;
            Nom = nom;
        }

        public AAnimal(string nom, Sexe sexe) : this(nom, sexe, DateTime.Now)
        {

        }

        public abstract void Manger();

        public void Reproduction(AAnimal partenaire)
        {
            //if(this.Equals(partenaire) && this.Sexe != partenaire.Sexe)
        }

        public override string ToString()
        {
            return string.Format("{1} le/la/l' {0}", this.GetType().Name, this.Nom);
        }

        public override bool Equals(Object animal)
        {
            if (this.GetType() == this.GetType())
            {
                return true;
            }

           

            return false;
        }
    }

    public enum Sexe{
        Male,
        Femelle
    }

    

}
