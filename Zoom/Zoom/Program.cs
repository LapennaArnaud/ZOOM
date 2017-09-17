using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.BLL.Model.Animal;
using Zoom.BLL.Controleur;
using Zoom.BLL.Gestionnaire;

namespace Zoom
{
    class Program
    {
        static void Main(string[] args)
        {
            JeuEssai();
            
            Console.ReadLine();

            
        }

        /**
        * Methods
        */
        public static void JeuEssai()
        {
            Zoo zoom = new Zoo("Zoologie","25 rue du tracteur", "Perdivile", 10.3);
            
            AAnimal l1 = GAnimal.AddLion("Georges", ESexe.Male);

            Console.WriteLine(l1.ToString());
        }
    }
}
