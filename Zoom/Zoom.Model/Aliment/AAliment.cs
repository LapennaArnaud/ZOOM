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

        public double Prix { get; set; }

        public DateTime Peremption { get; set; }

        public AAliment(int id, string nom, double prix)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prix = prix;
            this.Peremption = DateTime.Now.AddYears(+10);
        }

        public override string ToString()
        {
            return string.Format("ID : {0} Type : {1} Nom : {2} Prix : {3}", this.Id, this.GetType().Name, this.Nom, this.Prix);
        }

    }
}
