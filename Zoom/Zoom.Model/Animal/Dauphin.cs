using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.Model.Animal.Interface;

namespace Zoom.Model.Animal
{
    public class Dauphin : AAnimal, IEntite, ICarnivore
    {
        public override int Maturite { get; set; } = 4;
        public override int NbPatte { get; set; } = 0;

        public int NbNageoire { get; set; } = 4;

        public Dauphin(int id, string nom, ESexe sexe) : base(id, nom, sexe, DateTime.Now)
        {

        }

        public Dauphin(int id, string nom, ESexe sexe, DateTime date) : base(id, nom, sexe, date)
        {

        }

        public Dauphin(int id, string nom, ESexe sexe, DateTime date, AAnimal pere, AAnimal mere) : base(id, nom, sexe, date, pere, mere)
        {
        }

        public Dauphin(int id, string nom, ESexe sexe, AAnimal pere, AAnimal mere) : base(id, nom, sexe, pere, mere)
        {
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" Nageaoires : {0}", this.NbNageoire);
        }
    }
}
