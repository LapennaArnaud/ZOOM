using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.Model.Animal;
using Zoom.BLL.Controleur;
using Zoom.DAL.Gestionnaire;
using Zoom.Model;
using Zoom.Model.Personne;
using Zoom.BLL.Service;
using static Zoom.Model.Animal.AAnimal;
using static Zoom.Model.Personne.APersonne;
using Zoom.Model.Aliment;
using Zoom.Model.Structure;

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

            BaseService.Creer(typeof(Lion), new object[]{ "GeorgetteBis", AAnimal.ESexe.Femelle, DateTime.Now.AddYears(-5) });
            BaseService.Creer(typeof(Lion), new object[] { "GeorgesBis", AAnimal.ESexe.Male, DateTime.Now.AddYears(-5) });
            BaseService.Creer(typeof(Crocodile), new object[] { "CrocoBis", AAnimal.ESexe.Male, DateTime.Now.AddYears(-5) });
            BaseService.Creer(typeof(Dauphin), new object[] { "DauphinBis", AAnimal.ESexe.Male, DateTime.Now.AddYears(-5) });

            
            //BaseService.Creer(typeof(Animateur), new object[] {"Testi", "Georges", APersonne.ESexe.Femme, DateTime.Now.AddYears(-20) });

            BaseService.Creer(typeof(Aquarium), new object[] { "noob", 100, 200 });
            BaseService.Creer(typeof(Enclos), new object[] { "noob2", 100, 200 });

            S_Structure.AffecterAnimal((AStructure)(GEntite<IEntite>.GetOnebyID(5)), (AAnimal)(GEntite<IEntite>.GetOnebyID(1)));
            S_Structure.AffecterAnimal((AStructure)(GEntite<IEntite>.GetOnebyID(4)), (AAnimal)(GEntite<IEntite>.GetOnebyID(3)));
            S_Structure.AffecterAnimal((AStructure)(GEntite<IEntite>.GetOnebyID(5)), (AAnimal)(GEntite<IEntite>.GetOnebyID(2)));
            S_Structure.AffecterAnimal((AStructure)(GEntite<IEntite>.GetOnebyID(5)), (AAnimal)(GEntite<IEntite>.GetOnebyID(0)));

            S_Structure.GetAllAEnclos().ToList().ForEach(Console.Write);

            S_Structure.DesaffecterAnimal((AStructure)(GEntite<IEntite>.GetOnebyID(5)), (AAnimal)(GEntite<IEntite>.GetOnebyID(0)));

            S_Structure.GetAllAEnclos().ToList().ForEach(Console.Write);

            //APersonne p2 = GPersonne.AddVisiteur("Woulzy", "Charles", APersonne.ESexe.Homme, ECategorieBillet.Adulte);
            //S_Animal.Reproduction((AAnimal)BaseService.GetOnebyID(0), (AAnimal)BaseService.GetOnebyID(1));


            // List<IEntite> lista = BaseService.GetAll();
            /*foreach(AAnimal a in lista.Where(x => x is AAnimal))
            {
                Console.WriteLine(a.ToString() + " \n\r       Pere : " + a.Pere);
               
            }
            Console.WriteLine(S_Animal.AfficherAll());
            foreach (APersonne p in lista.Where(x => x is APersonne))
            {
                Console.WriteLine(p.ToString());

            }*/

            /* BaseService.Creer(typeof(Cereale), new object[] { "blé" });

             BaseService.Creer(typeof(Stock), new object[] { "Stock1", 10, 10 });

             Console.WriteLine(BaseService.AfficherAll() + "\n\r");

             Console.WriteLine(S_Aliment.AfficherAll() + "\n\r");

             Console.WriteLine(S_Structure.AfficherAll() + "\n\r");

             Stock s = (Stock)BaseService.GetOnebyID(7);
             AAliment al = (AAliment)BaseService.GetOnebyID(6);

             s.ListeAliment.Add(al, 10);

             BaseService.Supprimer(BaseService.GetOnebyID(6));

             Console.WriteLine(S_Structure.AfficherAll() + "\n\r");
             List<AAliment> aa = s.ListeAliment.Keys.ToList();
             s.ListeAliment.Keys.ToList().ForEach(Console.WriteLine);

             */


            /* foreach (Crocodile a in lista.Where(x => x is Crocodile))
             {
                 Console.WriteLine(a.ToString());

             }*/

            //Console.WriteLine(GAnimal.AfficherAll());
            //Console.WriteLine(GPersonne.AfficherAll());
        }
    }
}
