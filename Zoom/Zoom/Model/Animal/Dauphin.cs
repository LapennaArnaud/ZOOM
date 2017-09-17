using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom.BLL.Model.Animal
{
    public class Dauphin : AAnimal
    {

        public Dauphin(int id, string nom, ESexe sexe) : base(id, nom, sexe, DateTime.Now)
        {

        }

        public Dauphin(int id, string nom, ESexe sexe, DateTime date) : base(id, nom, sexe, date)
        {

        }

        public override int Maturite => 3;

        public override void Manger()
        {
            throw new NotImplementedException();
        }
    }
}
