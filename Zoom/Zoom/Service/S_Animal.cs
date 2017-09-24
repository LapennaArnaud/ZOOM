using System;
using System.Collections.Generic;
using Zoom.DAL.Gestionnaire;
using Zoom.Model;
using Zoom.Model.Aliment;
using Zoom.Model.Animal;
using Zoom.Model.Animal.Interface;
using static Zoom.Model.Animal.AAnimal;

namespace Zoom.BLL.Service
{
    public class S_Animal : BaseService
    {
        public static string Reproduction(AAnimal partenaire1, AAnimal partenaire2)
        {
            string res = "";
            if (
                MemeEspece(partenaire1, partenaire1)
                && partenaire1.Sexe != partenaire2.Sexe
                && CalculAge(partenaire1) >= partenaire1.Maturite
                && CalculAge(partenaire2) >= partenaire2.Maturite
                && !partenaire1.Equals(partenaire2)
                )
            {
                // Set father at first position
                if (partenaire1.Sexe.Equals(ESexe.Male))
                    CreateChild(partenaire1, partenaire2);
                else
                    CreateChild(partenaire2, partenaire1);
                res = "Reproduit";
            }
            else
            {
                res = "Non reproduit";
            }
            return res;
        }

        public static void CreateChild(AAnimal pere = null, AAnimal mere = null)
        {
            Random random = new Random();
            Array values = Enum.GetValues(typeof(ESexe));
            ESexe randomSexe = (ESexe)values.GetValue(random.Next(values.Length));

            CreateRandomAnimal(pere, mere, randomSexe);
        }

        public static void CreateRandomAnimal(AAnimal pere = null, AAnimal mere = null, ESexe sexe = ESexe.Femelle)
        {
            Random random = new Random();
            Type t = typeof(AAnimal);
            if (pere != null && mere != null)
            {
                t = pere.GetType();
                Creer(t, new object[] { pere.Nom + mere.Nom, sexe, pere, mere });
            }
            
        }

        public static int CalculAge(AAnimal animal)
        {
            return (DateTime.Now.Year - animal.DateNaissance.Year);
        }

        public static bool MemeEspece(AAnimal animal1, AAnimal animal2)
        {
            if (animal1.GetType() == animal2.GetType())
                return true;
            return false;
        }

        public static void Manger(AAnimal animal, AAliment aliment)
        {
            if(!GetEtatFaim(animal).Equals(EEtatFaim.Repu))
            {
                if (animal is ICarnivore && aliment is Viande)
                {
                    animal.Faim += 10;
                }
                else if (animal is IHerbivore && (aliment is Legume || aliment is Fruit))
                {
                    animal.Faim += 15;
                }
                else if (animal is IOmnivore)
                {
                    animal.Faim += 12;
                }
                else
                    throw new Exception(animal.GetType().Name + " ne peut manger l'aliment : " + aliment.GetType().Name);
            } 
        }
        public static void Soigner(AAnimal animal)
        {
            
             throw new Exception(" Soigner pas implementé ");
            
        }

        public static Enum GetEtatFaim(AAnimal animal)
        {
            if (animal.Faim >= 0 && animal.Faim <= 25 )
            {
                return EEtatFaim.Affame;
            }
            else if (animal.Faim >= 26 && animal.Faim <= 50)
            {
                return  EEtatFaim.Faim;
            }
            else if (animal.Faim >= 51 && animal.Faim <= 75)
            {
                return  EEtatFaim.Bon;
            }
            else
            {
                return  EEtatFaim.Repu;
            }
        }

        public new static List<IEntite> GetAll()
        {
            return GEntite<IEntite>.GetAll().FindAll(x => x is AAnimal);
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
