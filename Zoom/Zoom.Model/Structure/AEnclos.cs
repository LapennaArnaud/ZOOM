using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.Model.Animal;

namespace Zoom.Model.Structure
{
    public class AEnclos : AStructure, IEntite
    {
        public List<AAnimal> ListAnimal { get; set; }

        public AEnclos(int id, string nom, int longueur, int largeur) : base(id, nom, longueur, largeur)
        {
            this.ListAnimal = new List<AAnimal>();
        }
        public override string ToString()
        {
            string res = base.ToString();
            foreach (AAnimal animal in this.ListAnimal)
            {
                res += "\n    " + animal.ToString();
            }
            return res;
        }
    }
}
