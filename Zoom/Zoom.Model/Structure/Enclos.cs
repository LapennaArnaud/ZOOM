using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.Model.Animal;

namespace Zoom.Model.Structure
{
    public class Enclos : AEnclos, IEntite
    {
        
        public Enclos(int id, string nom, int longueur, int largeur) : base (id, nom, longueur, largeur)
        {
            
        }
    }
}
