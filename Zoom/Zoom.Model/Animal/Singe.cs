using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.Model.Animal.Interface;

namespace Zoom.Model.Animal
{
    public class Singe : AAnimal, IEntite, IOmnivore
    {
        public override int Maturite { get; set; } = 4;
        public override int NbPatte { get; set; } = 4;
        public Singe(int id, string nom, ESexe sexe) : base(id, nom, sexe, DateTime.Now)
        {

        }

        public Singe(int id, string nom, ESexe sexe, DateTime date) : base(id, nom, sexe, date)
        {

        }

        public Singe(int id, string nom, ESexe sexe, DateTime date, AAnimal pere, AAnimal mere) : base(id, nom, sexe, date, pere, mere)
        {
        }

        public Singe(int id, string nom, ESexe sexe, AAnimal pere, AAnimal mere) : base(id, nom, sexe, pere, mere)
        {
        }
    }
}
