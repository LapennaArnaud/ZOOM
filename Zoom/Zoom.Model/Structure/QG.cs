using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom.Model.Structure
{
    public class QG : AStructure, IEntite
    {
        public QG(int id, string nom, int longueur, int largeur) : base(id, nom, longueur, largeur)
        {

        }
    }
}
