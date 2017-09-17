using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.BLL.Model.Animal;

namespace Zoom.BLL.Gestionnaire
{
    public static class GAnimal
    {
        private static int id = 0;

        private static List<AAnimal> ListAnimal { get; set; } = new List<AAnimal>();

        public static AAnimal AddGirafe(string nom, ESexe sexe)
        {
            AAnimal g = new Girafe(id, nom, sexe);
            ListAnimal.Add(g);
            return g;
        }

        public static AAnimal AddCrocodile(string nom, ESexe sexe)
        {
            AAnimal g = new Crocodile(id, nom, sexe);
            ListAnimal.Add(g);
            return g;
        }

        public static AAnimal AddDauphin(string nom, ESexe sexe)
        {
            AAnimal g = new Dauphin(id, nom, sexe);
            ListAnimal.Add(g);
            return g;
        }

        public static AAnimal AddLion(string nom, ESexe sexe)
        {
            AAnimal g = new Lion(id, nom, sexe);
            ListAnimal.Add(g);
            return g;
        }

        public static AAnimal AddSinge(string nom, ESexe sexe)
        {
            AAnimal g = new Singe(id, nom, sexe);
            ListAnimal.Add(g);
            return g;
        }

        public static void RemoveAnimal(AAnimal a)
        {  
            ListAnimal.Remove(a);
        }

    }
}
