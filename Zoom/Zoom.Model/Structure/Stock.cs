using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.Model.Aliment;

namespace Zoom.Model.Structure
{
    public class Stock : AStructure, IEntite
    {
        public Dictionary<AAliment, int> ListeAliment { get; set; }

        public Stock(int id, string nom, int longueur, int largeur) : base (id, nom, longueur, largeur)
        {
            this.ListeAliment = new Dictionary<AAliment, int>();
        }
    }
}
