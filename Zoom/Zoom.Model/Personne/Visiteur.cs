using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom.Model.Personne
{
    class Visiteur : APersonne, IEntite
    {
        public ECategorieBillet CategorieBillet { get; set; }

        public Visiteur(int id, string nom, string prenom, ESexe sexe, ECategorieBillet categorieBillet) : base(id, nom, prenom, sexe)
        {
            CategorieBillet = categorieBillet;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" dont la catégorie du billet est {0}", this.CategorieBillet);
        }
    }
}
