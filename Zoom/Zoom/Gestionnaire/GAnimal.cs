using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.BLL.Model;
using Zoom.BLL.Model.Animal;

namespace Zoom.BLL.Gestionnaire
{
    public static class GAnimal
    {
        private static int id = 0;

        private static List<AAnimal> ListAnimal { get; set; } = new List<AAnimal>();

        public static AAnimal AddGirafe(string nom, ESexe sexe)
        {
            AAnimal g = new Girafe(AssigneID(), nom, sexe);
            ListAnimal.Add(g);
            return g;
        }

        public static AAnimal AddCrocodile(string nom, ESexe sexe)
        {
            AAnimal g = new Crocodile(AssigneID(), nom, sexe);
            ListAnimal.Add(g);
            return g;
        }

        public static AAnimal AddDauphin(string nom, ESexe sexe)
        {
            AAnimal g = new Dauphin(AssigneID(), nom, sexe);
            ListAnimal.Add(g);
            return g;
        }

        public static AAnimal AddLion(string nom, ESexe sexe)
        {
            AAnimal g = new Lion(AssigneID(), nom, sexe);
            ListAnimal.Add(g);
            return g;
        }

        public static AAnimal AddSinge(string nom, ESexe sexe)
        {
            AAnimal g = new Singe(AssigneID(), nom, sexe);
            ListAnimal.Add(g);
            return g;
        }

        public static void RemoveAnimal(AAnimal a)
        {  
            ListAnimal.Remove(a);
        }
        public static string AfficherAll()
        {
            string description = "";
            foreach (AAnimal a in ListAnimal)
            {
                description += a.ToString() + "\n";
            }
            return description;
        }

        public static int AssigneID()
        {
            var idOld = id;
            id++;
            return idOld;
        }
    }
}
