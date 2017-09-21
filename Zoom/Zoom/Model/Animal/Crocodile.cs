using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom.BLL.Model.Animal
{
    class Crocodile : AAnimal, IEntite
    {
        public Crocodile(int id, string nom, ESexe sexe) : base(id, nom, sexe, DateTime.Now)
        {

        }

        public Crocodile(int id, string nom, ESexe sexe, DateTime date) : base(id, nom, sexe, date)
        {

        }

        public override int Maturite => 3;

        public override void Manger()
        {
            throw new NotImplementedException();
        }

    }
}
