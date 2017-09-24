using System;
using System.Linq;
using Zoom.BLL.Service;
using Zoom.Model;
using Zoom.Model.Aliment;
using Zoom.Model.Animal;
using Zoom.Model.Personne;
using Zoom.Model.Structure;

namespace Zoom.GUI
{
    public class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                Initialisation();
                Accueil();
            }
            catch (Exception ex)
            {
                Accueil();
                Console.WriteLine("Une erreur s'est produite...");
                Console.WriteLine(ex.Message);
            }
        }
        public static void Initialisation()
        {
            // Create base model
            try
            {
                //AAnimal
                BaseService.Creer(typeof(Lion), new object[] { "Georgette", AAnimal.ESexe.Femelle, DateTime.Now.AddYears(-5) });
                BaseService.Creer(typeof(Lion), new object[] { "Georges", AAnimal.ESexe.Male, DateTime.Now.AddYears(-5) });
                BaseService.Creer(typeof(Crocodile), new object[] { "RémiCroco", AAnimal.ESexe.Male, DateTime.Now.AddYears(-5) });
                BaseService.Creer(typeof(Crocodile), new object[] { "GertrudeCroco", AAnimal.ESexe.Femelle, DateTime.Now.AddYears(-2) });
                BaseService.Creer(typeof(Singe), new object[] { "Singeou", AAnimal.ESexe.Male, DateTime.Now.AddYears(-1) });
                BaseService.Creer(typeof(Dauphin), new object[] { "DauphinBis", AAnimal.ESexe.Male, DateTime.Now.AddYears(-5) });

                //AAliment
                BaseService.Creer(typeof(Fruit), new object[] { "Banane",0.2 });
                BaseService.Creer(typeof(Fruit), new object[] { "Pomme", 0.4 });
                BaseService.Creer(typeof(Legume), new object[] { "Zharico", 0.5 });
                BaseService.Creer(typeof(Legume), new object[] { "Choux", 0.1 });
                BaseService.Creer(typeof(Viande), new object[] { "Steak", 0.8 });
                BaseService.Creer(typeof(Viande), new object[] { "Poiskaï", 0.7 });

                //Employe
                BaseService.Creer(typeof(Animateur), new object[] { "Anni", "Géraldine", APersonne.ESexe.Femme, DateTime.Now.AddYears(-20) });
                BaseService.Creer(typeof(Veterinaire), new object[] { "Vetéri", "Georges", APersonne.ESexe.Homme, DateTime.Now.AddYears(-30) });
                BaseService.Creer(typeof(Securite), new object[] { "LaMon", "Tagne", APersonne.ESexe.Homme, DateTime.Now.AddYears(-35) });

                //Visiteur
                BaseService.Creer(typeof(Visiteur), new object[] { "Mi", "Oche", APersonne.ESexe.Femme, ECategorieBillet.Enfant });
                BaseService.Creer(typeof(Visiteur), new object[] { "Grand", "Dadet", APersonne.ESexe.Homme, ECategorieBillet.Adulte });
                BaseService.Creer(typeof(Visiteur), new object[] { "Has", "Been", APersonne.ESexe.Femme, ECategorieBillet.Adulte });
                BaseService.Creer(typeof(Visiteur), new object[] { "Glan", "Deur", APersonne.ESexe.Homme, ECategorieBillet.Etudiant });

                //AEnclos
                BaseService.Creer(typeof(Aquarium), new object[] { "NoobertyLand", 100, 200, 10 });
                BaseService.Creer(typeof(Enclos), new object[] { "Enclos2", 100, 200 });

                // Affectation
                S_Structure.AffecterAnimal((AStructure)S_Structure.GetAllAEnclos().ElementAt(0), (AAnimal)S_Animal.GetAll().ElementAt(5));
                S_Structure.AffecterAnimal((AStructure)S_Structure.GetAllAEnclos().ElementAt(1), (AAnimal)S_Animal.GetAll().ElementAt(2));
                S_Structure.AffecterAnimal((AStructure)S_Structure.GetAllAEnclos().ElementAt(1), (AAnimal)S_Animal.GetAll().ElementAt(1));
                S_Structure.AffecterAnimal((AStructure)S_Structure.GetAllAEnclos().ElementAt(1), (AAnimal)S_Animal.GetAll().ElementAt(0));
                S_Structure.AffecterAnimal((AStructure)S_Structure.GetAllAEnclos().ElementAt(1), (AAnimal)S_Animal.GetAll().ElementAt(3));
                S_Structure.AffecterAnimal((AStructure)S_Structure.GetAllAEnclos().ElementAt(1), (AAnimal)S_Animal.GetAll().ElementAt(4));

                // AAliment in Zoo
                S_Zoo.AjouterAliment((AAliment)S_Aliment.GetAll().ElementAt(0), 50);
                S_Zoo.AjouterAliment((AAliment)S_Aliment.GetAll().ElementAt(1), 50);
                S_Zoo.AjouterAliment((AAliment)S_Aliment.GetAll().ElementAt(2), 50);
                S_Zoo.AjouterAliment((AAliment)S_Aliment.GetAll().ElementAt(3), 50);
                S_Zoo.AjouterAliment((AAliment)S_Aliment.GetAll().ElementAt(4), 50);
                S_Zoo.AjouterAliment((AAliment)S_Aliment.GetAll().ElementAt(5), 50);

            }
            catch (Exception e) // Error Creation
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
           /* try
            {
                S_Structure.AffecterAnimal((AStructure)S_Structure.GetAllAEnclos().ElementAt(0), (AAnimal)S_Animal.GetAll().ElementAt(3));
                S_Structure.AffecterAnimal((AStructure)S_Structure.GetAllAEnclos().ElementAt(1), (AAnimal)S_Animal.GetAll().ElementAt(2));
                S_Structure.AffecterAnimal((AStructure)S_Structure.GetAllAEnclos().ElementAt(1), (AAnimal)S_Animal.GetAll().ElementAt(1));
                S_Structure.AffecterAnimal((AStructure)S_Structure.GetAllAEnclos().ElementAt(1), (AAnimal)S_Animal.GetAll().ElementAt(0));

                Console.WriteLine("\n\r------------- Liste Enclos ---------- \n\r");
                S_Structure.GetAllAEnclos().ToList().ForEach(Console.WriteLine);

                S_Structure.DesaffecterAnimal((AStructure)S_Structure.GetAllAEnclos().ElementAt(1), (AAnimal)S_Animal.GetAll().ElementAt(0));
                Console.WriteLine("\n\r------------- Liste Enclos ---------- \n\r");
                S_Structure.GetAllAEnclos().ToList().ForEach(Console.WriteLine);

                S_Animal.Reproduction((AAnimal)S_Animal.GetAll().ElementAt(0), (AAnimal)S_Animal.GetAll().ElementAt(1));

                Console.WriteLine("\n\r------------- Liste Entités ---------- \n\r");
                BaseService.GetAll().ToList().ForEach(Console.WriteLine);

                Console.WriteLine("\n\r------------- Liste Animals ---------- \n\r");
                S_Animal.AfficherAll().ToList().ForEach(Console.Write);

                Console.WriteLine("\n\r------------- Test nourrir ---------- \n\r");
                S_Personne.Nourrir((APersonne)S_Personne.GetAll().ElementAt(0), (AAnimal)S_Animal.GetAll().ElementAt(0), (AAliment)S_Aliment.GetAll().ElementAt(0));
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }*/
        }
        public static void Accueil(string message = "")
        {

            string res;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("Bienvenue dans Zoom 'The fastest Zoo alive'");
            Console.WriteLine("");
            Console.WriteLine("Veuillez selectionner un des choix : ");
            Console.WriteLine("1. J'ai quoi dans mon Zoom ?");
            Console.WriteLine("1. Animaux");
            Console.WriteLine("2. Spectacle");
            Console.WriteLine("3. Employe");
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine(message);
            res = Console.ReadLine();
            switch (res.ToString())
            {
                case "1":
                    JaiQuoiDansMonZoom();
                    break;
                case "2":
                    MenuAnimaux();
                    break;
                case "3":
                    MenuVisiteur();
                    break;
                default:
                    Accueil();
                    break;
            }
        }

        public static void JaiQuoiDansMonZoom()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("#######################################################################################################################");
                Console.WriteLine("J'ai quoi dans mon Zoom :");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Liste Enclos ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;
                S_Structure.GetAllAEnclos().ToList().ForEach(Console.WriteLine);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Liste Animals ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;
                S_Animal.AfficherAll().ToList().ForEach(x =>
                {
                    Console.WriteLine(x.ToString());
                });

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Liste Esclaves ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;
                S_Personne.GetAllEmploye().ToList().ForEach(x =>
                {
                    Console.WriteLine(x.ToString());
                });

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Liste Porte-monnaies potentiels ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;
                S_Personne.GetAllVisiteur().ToList().ForEach(x =>
                {
                    Console.WriteLine(x.ToString());
                });

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Liste Porte-monnaies potentiels ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;
                S_Personne.GetAllVisiteur().ToList().ForEach(x =>
                {
                    Console.WriteLine(x.ToString());
                });

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Liste Porte-monnaies dans Zoom ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;
                S_Zoo.GetAllVisiteur().ToList().ForEach(x =>
                {
                    Console.WriteLine(x.ToString());
                });

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Stock de Zoom ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(S_Zoo.AfficherStock());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Accueil();
        }

        public static void MenuAnimaux()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("");
            Console.WriteLine("1. Vétérinaire rescousse : donner à manger ");
            Console.WriteLine("2. Construire un enclos ");
            Console.WriteLine("3. Construire un aquarium ");
            Console.WriteLine("4. Vous êtes un Dieu ? Créer un animal ");
            Console.WriteLine("5. Vous êtes soucieux de la biodiversité ? Reproduire un animal ");
            string res = Console.ReadLine();
            try
            {
                switch (res.ToString())
                {
               
                    case "1":
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(S_Animal.AfficherAll());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Choisissez l'animal : ID");
                    Console.ForegroundColor = ConsoleColor.White;
                    string id = Console.ReadLine();


                    var animal = BaseService.GetOnebyID(int.Parse(id));

                    S_Zoo.AfficherStock();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Choisissez l'aliment : ID");
                    Console.ForegroundColor = ConsoleColor.White;

                    var idProduit = Console.ReadLine();
                    var aliment = BaseService.GetOnebyID(int.Parse(idProduit));

                    S_Animal.Manger((AAnimal)animal, (AAliment)aliment);

                    Console.WriteLine(animal + " nourri");

                    break;
                    case "2":
                        Console.WriteLine("Nom de l'enclos :");
                        var nom = Console.ReadLine();
                        Console.WriteLine("Longueur de l'enclos :");
                        var longueur = Console.ReadLine();
                        Console.WriteLine("Largeur de l'enclos :");
                        var largeur = Console.ReadLine();
                        BaseService.Creer(typeof(Enclos), new object[] {nom, longueur, largeur });
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Construction réalisée gratuitement !");
                        break;
                    case "3":
                        Console.WriteLine("Nom de l'aquarium :");
                        var nom2 = Console.ReadLine();
                        Console.WriteLine("Longueur de l'aquarium :");
                        var longueur2 = Console.ReadLine();
                        Console.WriteLine("Largeur de l'aquarium :");
                        var largeur2 = Console.ReadLine();
                        Console.WriteLine("Hauteur de l'aquarium :");
                        var hauteur = Console.ReadLine();
                        BaseService.Creer(typeof(Aquarium), new object[] { nom2, longueur2, largeur2, hauteur });
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Construction réalisée gratuitement !");
                        break;
                    case "4":
                        CreerAnimal();
                        break;
                    case "5":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\r------------- Liste Animals ---------- \n\r");
                        Console.ForegroundColor = ConsoleColor.White;
                        S_Animal.AfficherAll().ToList().ForEach(x =>
                        {
                            Console.WriteLine(x.ToString());
                        });

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Choisissez le premier parent : ID");
                        Console.ForegroundColor = ConsoleColor.White;

                        var idParent1 = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Choisissez le premier parent : ID");
                        Console.ForegroundColor = ConsoleColor.White;

                        var idParent2 = Console.ReadLine();

                        Console.WriteLine(S_Animal.Reproduction((AAnimal)BaseService.GetOnebyID(int.Parse(idParent1)), (AAnimal)BaseService.GetOnebyID(int.Parse(idParent1))));

                        break;

                    default:
                        Accueil();
                    break;
                }
            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message + " Error lors de la saisie de l'ID");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Accueil();
        }
        public static void MenuVisiteur()
        {
            try
            {
                Console.Clear();
                /*Console.WriteLine("#######################################################################################################################");
                Console.WriteLine("J'ai quoi dans mon Zoom :");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Liste Enclos ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;
                S_Structure.GetAllAEnclos().ToList().ForEach(Console.WriteLine);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Liste Animals ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;
                S_Animal.AfficherAll().ToList().ForEach(x =>
                {
                    Console.WriteLine(x.ToString());
                });

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Liste Esclaves ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;
                S_Personne.GetAllEmploye().ToList().ForEach(x =>
                {
                    Console.WriteLine(x.ToString());
                });

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Liste Porte-monnaies potentiels ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;
                S_Personne.GetAllVisiteur().ToList().ForEach(x =>
                {
                    Console.WriteLine(x.ToString());
                });

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Liste Porte-monnaies potentiels ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;
                S_Personne.GetAllVisiteur().ToList().ForEach(x =>
                {
                    Console.WriteLine(x.ToString());
                });

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Liste Porte-monnaies dans Zoom ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;
                S_Zoo.GetAllVisiteur().ToList().ForEach(x =>
                {
                    Console.WriteLine(x.ToString());
                });

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Stock de Zoom ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(S_Zoo.AfficherStock());
                */
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Accueil();
        }
        private static void CreerAnimal()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vous achetez un animal pour quel enclos ?");
            Console.ForegroundColor = ConsoleColor.White;

            S_Structure.GetAllAEnclos().ForEach(x =>
            {
                Console.WriteLine(x.ToString());
            });
            var enclosId = Console.ReadLine();

            Console.WriteLine("Choisisser le numéro de l'animal :");
            Console.WriteLine(" 1 - Lion");
            Console.WriteLine(" 2 - Crocodile");
            Console.WriteLine(" 3 - Dauphin");
            Console.WriteLine(" 4 - Singe");
            Console.WriteLine(" 5 - Girafe");
            var animal = Console.ReadLine();

            Console.WriteLine("Nom :");
            var nom = Console.ReadLine();
            Console.WriteLine("Age :");
            var age = Console.ReadLine();
            Console.WriteLine("Sexe : 0 = Male | 1 = Femelle ");
            var sexe = Console.ReadLine();

            Type t = typeof(Lion);
            switch (animal)
            {
                case "1":
                    t = typeof(Lion);
                    break;
                case "2":
                    t = typeof(Crocodile);
                    break;
                case "3":
                    t = typeof(Dauphin);
                    break;
                case "4":
                    t = typeof(Singe);
                    break;
                case "5":
                    t = typeof(Girafe);
                    break;
            }
            Enum sexy = (int.Parse(sexe) == 0 ? AAnimal.ESexe.Male : AAnimal.ESexe.Femelle);
            BaseService.Creer(t, new object[] { nom, sexy, DateTime.Now.AddYears(int.Parse(age)) });

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Animal créé");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
