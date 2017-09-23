using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.Model.Animal;

namespace Zoom.Model.Structure
{
    public class Aquarium : AEnclos, IEntite
    {
        public int Hauteur { get; set; }

        public Aquarium(int id, string nom, int longueur, int largeur, int hauteur) : base(id, nom, longueur, largeur)
        {
            this.Hauteur = hauteur;
        }
    }
}
