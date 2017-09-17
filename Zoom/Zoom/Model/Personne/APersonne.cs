using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom.BLL.Model.Personne
{
    public abstract class APersonne
    {
        public int Id { get; private set; }

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
            string determinant = (this.Sexe == ESexe.Femme ? "la" : "le");
            return string.Format("{4} {0} {1} {2} {3}", this.Prenom, this.Nom, determinant, this.GetType().Name, this.Id);
        }

    }
}
