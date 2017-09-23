using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.Model.Personne;

namespace Zoom.Model.Structure
{
    public abstract class AStructure : IEntite
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public int Longueur { get; set; }

        public int Largeur { get; set; }


        public APersonne Surveillant { get; set; }

        public AStructure(int id, string nom, int longeur, int largeur)
        {
            this.Id = id;
            this.Nom = nom;
            this.Longueur = longeur;
            this.Largeur = largeur;
        }
        public override string ToString()
        {
            return string.Format("ID : {0} Type : {1} Nom : {2} ", this.Id, this.GetType().Name, this.Nom);
        }

    }
}
 