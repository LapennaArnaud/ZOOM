using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom.BLL.Model.Animal
{
    public class Lion : AAnimal
    {

        public Lion(int id, string nom, ESexe sexe) : base(id, nom, sexe, DateTime.Now)
        {

        }

        public Lion(int id, string nom, ESexe sexe, DateTime date) : base(id, nom, sexe, date)
        {

        }
        public override void Manger()
        {
            throw new NotImplementedException();
        }
    }
}
