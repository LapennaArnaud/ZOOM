using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.BLL.Model.Animal.Interface;

namespace Zoom.BLL.Model.Animal
{
    public class Lion : AAnimal, ICarnivore
    {
        public override int Maturite { get => 4; }

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
