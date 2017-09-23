using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.DAL.Gestionnaire;
using Zoom.Model;
using Zoom.Model.Animal;
using Zoom.Model.Personne;
using Zoom.Model.Structure;

namespace Zoom.BLL.Service
{
    public class S_Structure : BaseService
    {
        
        public static void AffecterAnimal(AStructure s, AAnimal animal)
        {
            // The animal can be only in one EEnclos
            if (s is Aquarium a && animal is Dauphin)
            {
                DesaffecterAnimal(animal);
                a.ListAnimal.Add(animal);
            }
            else if (s is Enclos e && !(animal is Dauphin)) {
                DesaffecterAnimal(animal);
                e.ListAnimal.Add(animal);
            }
            else
            {
                throw new Exception("Type d'enclos invalide");
            }
        }

        public static void DesaffecterAnimal(AStructure s, AAnimal animal)
        {
            if (s is Aquarium a)
                a.ListAnimal.Remove(animal);

            else if (s is Enclos e)
                e.ListAnimal.Remove(animal);
        }

        public static void DesaffecterAnimal(AAnimal animal)
        {
            List<IEntite> liEnclos = GetAllAEnclos();
            foreach(AEnclos enclo in liEnclos)
            {
                enclo.ListAnimal.Remove(animal);
            }
        }

        // Impossible to secure 2 structures for the same securiteMan
        public static void Surveiller(AStructure s, Securite sc)
        {
            if (GetAllSecureStructure().FirstOrDefault(x => ((AStructure)x).Surveillant.Equals(sc)) is null)
                s.Surveillant = sc;
        }

        public static void StopSurveiller(AStructure s)
        {
            s.Surveillant = null;
        }

        public static List<IEntite> GetAllSecureStructure()
        {
            List<IEntite> allSecureStructure = GEntite<IEntite>.GetAll().FindAll(x => x is AStructure);

            return allSecureStructure.FindAll(x => !(((AStructure)x).Surveillant is null));

        }
        public static List<IEntite> GetAllAEnclos()
        {
            return GEntite<IEntite>.GetAll().FindAll(x => x is AEnclos);
        }

        public new static List<IEntite> GetAll()
        {
            return GEntite<IEntite>.GetAll().FindAll(x => x is AStructure);
        }

        public new static string AfficherAll()
        {
            string description = "";
            foreach (IEntite a in GetAll())
            {
                description += a.ToString() + "\n";
            }
            return description;
        }

    }
}
