using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom.Business.Model.Animal
{
    public class Girafe : AAnimal
    {
        public override void Manger()
        {
            throw new NotImplementedException();
        }

        public Girafe(string nom, Sexe sexe) : base(nom,sexe)
        {

        }
    }
}
