using System;
using System.Collections.Generic;
using Zoom.DAL.Gestionnaire;
using Zoom.Model;
using Zoom.Model.Aliment;
using Zoom.Model.Animal;
using Zoom.Model.Personne;
using Zoom.Model.Personne.Interface;

namespace Zoom.BLL.Service
{
    public class S_Personne : BaseService
    {
        public static int CalculAge(Employe employe)
        {
            return (DateTime.Now.Year - employe.DateNaissance.Year);
        }

        public static void Nourrir(APersonne employe, AAnimal a, AAliment al)
        {
            if (employe is INourrir)
            {
                S_Animal.Manger(a, al); 
                S_Zoo.SupprimerAliment(al, 1);
            }
            else
                throw new Exception("Cette personne ne peut nourrir d'animal");
        }

        public static void Soigner(APersonne employe, AAnimal a)
        {
            if (employe is Veterinaire)
                S_Animal.Soigner(a);
            else
                throw new Exception(employe.GetType().Name + " ne peut soigner d'animal");
        }

        public new static List<IEntite> GetAll()
        {
            return GEntite<IEntite>.GetAll().FindAll(x => x is APersonne);
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
