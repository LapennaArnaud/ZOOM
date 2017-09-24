using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.Model.Aliment;
using Zoom.Model.Personne;
using Zoom.Model;

namespace Zoom.BLL.Service
{
    public class S_Zoo
    {
        public static void SupprimerArgent(double argent)
        {
            Zoo.getInstance().Tresorerie -= argent;
        }

        public static void AjouterArgent(double argent)
        {
            Zoo.getInstance().Tresorerie += argent;
        }
        public static void AjouterVisiteur(Visiteur visi)
        {
            Zoo.getInstance().ListVisiteur.Add(visi);
            if (visi.CategorieBillet.Equals(ECategorieBillet.Adulte))
                Zoo.getInstance().Tresorerie += Zoo.getInstance().TarifBillet;
            else if (visi.CategorieBillet.Equals(ECategorieBillet.Etudiant))
                Zoo.getInstance().Tresorerie += (Zoo.getInstance().TarifBillet * 0.7);
            else
                Zoo.getInstance().Tresorerie += (Zoo.getInstance().TarifBillet * 0.5);
        }

        public static void SupprimerVisiteur(Visiteur visi)
        {
            Zoo.getInstance().ListVisiteur.Remove(visi);
           
        }

        public static void SupprimerAliment(AAliment a, int quantite)
        {
            if (Zoo.getInstance().ListeAliment.ContainsKey(a))
            {
                int quantiteOld = 0;
                Zoo.getInstance().ListeAliment.TryGetValue(a, out quantiteOld);

                if (quantiteOld <= quantite)
                    Zoo.getInstance().ListeAliment[a] = 0;
                else
                {
                    Zoo.getInstance().ListeAliment[a] = quantiteOld - quantite;
                    quantiteOld = quantite; // set the exact quantite bought
                }

                SupprimerArgent(a.Prix * quantiteOld);
            }
        }

        public static void AjouterAliment(AAliment a, int quantite)
        {
            if (Zoo.getInstance().Tresorerie >= a.Prix * quantite)
            {
                if (Zoo.getInstance().ListeAliment.ContainsKey(a))
                    Zoo.getInstance().ListeAliment[a] += quantite;
                else
                    Zoo.getInstance().ListeAliment.Add(a, quantite);

                AjouterArgent((a.Prix * quantite));
            }

            else
                throw new Exception("Vous n'avez pas assez d'argent dans votre Zoom ! Trésorerie : " + Zoo.getInstance().Tresorerie);
        }

        public static List<Visiteur> GetAllVisiteur()
        {
            return Zoo.getInstance().ListVisiteur; 
        }

        public static string AfficherStock()
        {
            string res = "";
            foreach(AAliment a in Zoo.getInstance().ListeAliment.Keys){
                res += a.ToString() + " Quantité : " + Zoo.getInstance().ListeAliment[a].ToString();
                res += "\n\r";
            }
            return res;
        }

    }
}
