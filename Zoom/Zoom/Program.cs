using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.BLL.Model.Animal;
using Zoom.BLL.Controleur;
using Zoom.BLL.Gestionnaire;
using Zoom.BLL.Model;
using Zoom.BLL.Model.Personne;

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
            
            AAnimal a1 = GAnimal.AddLion("Georges", ESexe.Male);
            AAnimal a2 = GAnimal.AddCrocodile("Croc", ESexe.Femelle);
            AAnimal a3 = GAnimal.AddDauphin("Flipper", ESexe.Femelle);
            AAnimal a4 = GAnimal.AddGirafe("Girouf", ESexe.Male);
            AAnimal a5 = GAnimal.AddSinge("Kingkong", ESexe.Male);

            APersonne p1 = GPersonne.AddAnimateur("Testi","Georges", ESexe.Femme, DateTime.Now.AddYears(-20));
            APersonne p2 = GPersonne.AddVisiteur("Woulzy", "Charles", ESexe.Homme, ECategorieBillet.Adulte);


            Console.WriteLine(GAnimal.AfficherAll());
            Console.WriteLine(GPersonne.AfficherAll());
        }
    }
}
