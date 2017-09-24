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
    public class View
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
                S_Zoo.AcheterAliment((AAliment)S_Aliment.GetAll().ElementAt(0), 50);
                S_Zoo.AcheterAliment((AAliment)S_Aliment.GetAll().ElementAt(1), 50);
                S_Zoo.AcheterAliment((AAliment)S_Aliment.GetAll().ElementAt(2), 50);
                S_Zoo.AcheterAliment((AAliment)S_Aliment.GetAll().ElementAt(3), 50);
                S_Zoo.AcheterAliment((AAliment)S_Aliment.GetAll().ElementAt(4), 50);
                S_Zoo.AcheterAliment((AAliment)S_Aliment.GetAll().ElementAt(5), 50);

            }
            catch (Exception e) // Error Creation
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static void Accueil(string message = "")
        {

            string res;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("Bienvenue dans Zoom 'The fastest Zoo alive'");
            Console.WriteLine("");
            Console.WriteLine("Veuillez selectionner un des choix O grande divinité impériale : ");
            Console.WriteLine("1. STOCK     : J'ai quoi dans mon Zoom ?");
            Console.WriteLine("2. ANIMAUX   : Et les animaux ?");
            Console.WriteLine("3. VISITEURS : Gérer votre bourse Maîîîître, voici les Visiteurs");
            Console.WriteLine("4. ENCLOS    : Amusez-vous avec vos maléfiques Enclos");
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
                case "4":
                    MenuEnclos();
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
                Console.WriteLine("\n\r------------- Money for nothing ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;

                var tresor = S_Zoo.GetInstance().Tresorerie;
                if (tresor < 1000)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(tresor);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" Il va falloir remonter ça Maîîîîîître !");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(tresor);
                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" Toujours plus d'argent !");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Liste de vos Enclos ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;
                S_Structure.GetAllAEnclos().ToList().ForEach(Console.WriteLine);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Liste de vos Animaux ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;
                S_Animal.AfficherAll().ToList().ForEach(x =>
                {
                    Console.Write(x.ToString());
                });

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Liste de vos Esclaves ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;
                S_Personne.GetAllEmploye().ToList().ForEach(x =>
                {
                    Console.WriteLine(x.ToString());
                });

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Liste de vos Porte-monnaies potentiels ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;
                S_Personne.GetAllVisiteur().ToList().ForEach(x =>
                {
                    if(!S_Zoo.GetAllVisiteur().Contains(x))
                        Console.WriteLine(x);
                    
                });

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Liste de vos Porte-monnaies dans Zoom ---------- \n\r");
                Console.ForegroundColor = ConsoleColor.White;
                S_Zoo.GetAllVisiteur().ToList().ForEach(x =>
                {
                    Console.WriteLine(x.ToString());
                });

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\r------------- Stock de votre Zoom ---------- \n\r");
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
            Console.WriteLine("2. Vous êtes un Dieu ? Créer un animal ");
            Console.WriteLine("3. Vous êtes soucieux de la biodiversité ? Reproduire un animal ");
            Console.ForegroundColor = ConsoleColor.White;
            string res = Console.ReadLine();
            try
            {
                switch (res.ToString())
                {
               
                    case "1":
                        Console.WriteLine("\n\r------------- Liste de vos Animaux ---------- \n\r");
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(S_Animal.AfficherAll());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Choisissez l'animal : ID");
                    Console.ForegroundColor = ConsoleColor.White;
                    string id = Console.ReadLine();


                    var animal = BaseService.GetOnebyID(int.Parse(id));

                    S_Zoo.AfficherStock();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\r------------- Stock de l'alimentation de vos Animaux ---------- \n\r");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(S_Zoo.AfficherStock());
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Choisissez l'aliment : ID");
                    Console.ForegroundColor = ConsoleColor.White;

                    var idProduit = Console.ReadLine();
                    var aliment = BaseService.GetOnebyID(int.Parse(idProduit));

                    S_Animal.Manger((AAnimal)animal, (AAliment)aliment);

                    Console.WriteLine(animal + " nourri");

                    break;
                    case "2":
                        CreerAnimal();
                        break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\r------------- Liste de vos Animaux ---------- \n\r");
                        Console.ForegroundColor = ConsoleColor.White;
                        S_Animal.AfficherAll().ToList().ForEach(x =>
                        {
                            Console.Write(x.ToString());
                        });

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Choisissez le premier parent : ID");
                        Console.ForegroundColor = ConsoleColor.White;

                        var idParent1 = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Choisissez le second parent : ID");
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
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.White;
                
            }
            Accueil();
        }
        public static void MenuVisiteur()
        {
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("#######################################################################################################################");
                Console.WriteLine("");
                Console.WriteLine("1. Ouvrir les portes de votre Zoom !");
                Console.WriteLine("2. O grand divin, générez un visiteur ");
                Console.WriteLine("3. Virer un visiteur radin");
                Console.ForegroundColor = ConsoleColor.White;
                string res = Console.ReadLine();
                switch (res.ToString())
                {
                    case "1":
                       
                            S_Personne.GetAllVisiteur().ToList().ForEach(x =>
                            {
                                try
                                {
                                    S_Zoo.AjouterVisiteur((Visiteur)x);
                                    Console.WriteLine("Visiteur arrive : " +x.ToString());
                                }
                                catch (Exception e)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(e.Message);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            });
                        
                        break;
                    case "2":

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Nom :");
                        Console.ForegroundColor = ConsoleColor.White;
                        var nom = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Prenom :");
                        Console.ForegroundColor = ConsoleColor.White;
                        var prenom = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Sexe : 0 = Homme | 1 = Femme");
                        Console.ForegroundColor = ConsoleColor.White;
                        var sexe = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Billet : 0 = Enfant | 1 = Etudiant | 2 = Adulte ");
                        Console.ForegroundColor = ConsoleColor.White;
                        var billet = Console.ReadLine();

                        
                        Enum sexy = (int.Parse(sexe) == 0 ? APersonne.ESexe.Homme : APersonne.ESexe.Femme);
                        Enum billetrie = (int.Parse(billet) == 0 ? ECategorieBillet.Enfant : (int.Parse(billet) == 1 ? ECategorieBillet.Etudiant : ECategorieBillet.Adulte));

                        BaseService.Creer(typeof(Visiteur), new object[] { nom, prenom, sexy, billetrie });

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Visiteur créé");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "3":
                        

                        if(S_Personne.GetAllEmploye().ToList().FindAll(x => x is Securite).Count() != 0 
                            && S_Zoo.GetAllVisiteur().ToList().Count() != 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\r------------- Liste Securité man de Zoom ---------- \n\r");
                            Console.ForegroundColor = ConsoleColor.White;
                            S_Personne.GetAllEmploye().ToList().FindAll(x => x is Securite).ForEach(x =>
                            {
                                Console.WriteLine(x.ToString());
                            });

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Choisissez l'employé Securité : ID");
                            Console.ForegroundColor = ConsoleColor.White;

                            var idEmp = Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\r------------- Liste Porte-monnaies dans Zoom ---------- \n\r");
                            Console.ForegroundColor = ConsoleColor.White;
                            S_Zoo.GetAllVisiteur().ToList().ForEach(x =>
                            {
                                Console.WriteLine(x.ToString());
                            });

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Choisissez le visiteur  à virer : ID");
                            Console.ForegroundColor = ConsoleColor.White;

                            var idVisi = Console.ReadLine();

                            S_Personne.JeterDehors((Securite)S_Personne.GetOnebyID(int.Parse(idEmp)), (Visiteur) S_Personne.GetOnebyID(int.Parse(idVisi)));
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Vous n'avez aucun employe sécurité ou aucun visiteur dans votre park !");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    default:
                        Accueil();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Accueil();
        }
        public static void MenuEnclos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("");
            Console.WriteLine("1. Lister les enclos ");
            Console.WriteLine("2. Construire un enclos ");
            Console.WriteLine("3. Construire un aquarium ");
            Console.WriteLine("4. Du rangement ! Affecter animal à un enclos ");
            Console.WriteLine("5. Du désordre ! Vider enclos ");
            Console.ForegroundColor = ConsoleColor.White;
            string res = Console.ReadLine();
            try
            {
                switch (res.ToString())
                {

                    case "1":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\r------------- Liste Enclos ---------- \n\r");
                        Console.ForegroundColor = ConsoleColor.White;
                        S_Structure.GetAllAEnclos().ToList().ForEach(Console.Write);
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Nom de l'enclos :");
                        Console.ForegroundColor = ConsoleColor.White;
                        var nom = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Longueur de l'enclos :");
                        Console.ForegroundColor = ConsoleColor.White;
                        var longueur = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Largeur de l'enclos :");
                        Console.ForegroundColor = ConsoleColor.White;
                        var largeur = Console.ReadLine();
                        BaseService.Creer(typeof(Enclos), new object[] { nom, longueur, largeur });
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Construction réalisée gratuitement !");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Nom de l'aquarium :");
                        Console.ForegroundColor = ConsoleColor.White;
                        var nom2 = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Longueur de l'aquarium :");
                        Console.ForegroundColor = ConsoleColor.White;
                        var longueur2 = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Largeur de l'aquarium :");
                        Console.ForegroundColor = ConsoleColor.White;
                        var largeur2 = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Hauteur de l'aquarium :");
                        Console.ForegroundColor = ConsoleColor.White;
                        var hauteur = Console.ReadLine();
                        BaseService.Creer(typeof(Aquarium), new object[] { nom2, longueur2, largeur2, hauteur });
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Construction réalisée gratuitement !");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "4":
                        if (S_Structure.GetAllAEnclos().Count()!= 0 
                            && S_Animal.GetAllSansEnclos().Count() != 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\r------------- Liste Enclos ---------- \n\r");
                            Console.ForegroundColor = ConsoleColor.White;
                            S_Structure.GetAllAEnclos().ToList().ForEach(Console.Write);

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Sélectionnez l'enclos d'affectation : ID");
                            Console.ForegroundColor = ConsoleColor.White;
                            var idEnclos = Console.ReadLine();

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\r------------- Liste Animaux sans enclos ---------- \n\r");
                            Console.ForegroundColor = ConsoleColor.White;
                            S_Animal.GetAllSansEnclos().ToList().ForEach(Console.Write);

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Sélectionnez l'animal à affecter : ID");
                            Console.ForegroundColor = ConsoleColor.White;
                            var idanimal = Console.ReadLine();

                            AStructure s = (AStructure)BaseService.GetOnebyID(int.Parse(idEnclos));
                            AAnimal aa = (AAnimal)BaseService.GetOnebyID(int.Parse(idanimal));

                            S_Structure.AffecterAnimal(s, aa);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Animal : " + aa+" affecté à l'enclos : " + s);
                            Console.ForegroundColor = ConsoleColor.White;


                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Aucun animal n'étant pas en cage ou vous n'avez aucun enclos !");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        
                        


                        break;
                    case "5":
                        if (S_Structure.GetAllAEnclos().Count() != 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\r------------- Liste Enclos ---------- \n\r");
                            Console.ForegroundColor = ConsoleColor.White;
                            S_Structure.GetAllAEnclos().ToList().ForEach(Console.Write);

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\r Sélectionnez l'enclos à désaffecter : ID");
                            Console.ForegroundColor = ConsoleColor.White;
                            var idEnclos = Console.ReadLine();

                            

                            AStructure s = (AStructure)BaseService.GetOnebyID(int.Parse(idEnclos));
                            

                            S_Structure.DesaffecterEnclos(s);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Enclos :  " + s + " désaffecté ! ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Aucun enclos !");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    default:
                        Accueil();
                        break;
                }
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
