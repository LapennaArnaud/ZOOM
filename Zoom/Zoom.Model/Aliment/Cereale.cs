using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom.Model.Aliment
{
    public class Cereale : AAliment, IEntite
    {
        public Cereale(int id, string nom) : base(id, nom)
        {
            
        }
    }
}
