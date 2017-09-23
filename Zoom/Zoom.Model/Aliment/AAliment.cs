using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom.Model.Aliment
{
    public abstract class AAliment : IEntite
    {
        public int Id { get ; set ; }

        public string Nom { get; set; }

        public AAliment(int id, string nom)
        {
            this.Id = id;
            this.Nom = nom;
        }

        public override string ToString()
        {
            return string.Format("ID : {0} Type : {1} Nom : {2} ", this.Id, this.GetType().Name, this.Nom);
        }

    }
}
