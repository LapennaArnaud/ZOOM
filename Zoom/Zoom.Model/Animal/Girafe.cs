using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.Model.Animal.Interface;

namespace Zoom.Model.Animal
{
    public class Girafe : AAnimal, IEntite, IHerbivore
    {
        public override int Maturite { get; set; } = 4;
        public override int NbPatte { get; set; } = 4;


        public Girafe(int id, string nom, ESexe sexe) : base(id, nom, sexe, DateTime.Now)
        {

        }
        
        public Girafe(int id, string nom, ESexe sexe, DateTime date) : base(id, nom, sexe, date)
        {

        }

        public Girafe(int id, string nom, ESexe sexe, DateTime date, AAnimal pere, AAnimal mere) : base(id, nom, sexe, date, pere, mere)
        {
        }

        public Girafe(int id, string nom, ESexe sexe, AAnimal pere, AAnimal mere) : base(id, nom, sexe, pere, mere)
        {
        }
    }
}
