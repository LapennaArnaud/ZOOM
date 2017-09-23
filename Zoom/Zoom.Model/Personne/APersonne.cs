using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom.Model.Personne
{
    public abstract class APersonne : IEntite
    {
        public enum ESexe { Homme, Femme }
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public ESexe Sexe { get; set; }


        public APersonne(int id, string nom, string prenom, ESexe sexe)
        {
            Id = id;
            Sexe = sexe;
            Nom = nom;
            Prenom = prenom;
        }

        public override string ToString()
        {
            return string.Format("{3} {0} {1} {2}", this.Prenom, this.Nom, this.GetType().Name, this.Id);
        }

    }
}
