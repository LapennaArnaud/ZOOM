using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.BLL.Model;

namespace Zoom.BLL.Gestionnaire
{
    /**
     * Classe static gestionnaire de toutes les entités de notre zoo
     */ 
    public class GEntite<T> where T : IEntite
    {
        private static List<T> listeEntite = new List<T>();

        public static List<T> ListeEntite
        {
            get { return listeEntite; }
            set { listeEntite  = value; }
        }

        public static void Add(T entite)
        {
            listeEntite.Add(entite);
        }

        public static void Remove(T entite)
        {
            listeEntite.Remove(entite);
        }

        public static List<T> GetOnebyID(int id)
        {
            return ListeEntite.Find(x=> x.Id == id);
        }

        public static List<T> GetAll()
        {
            return ListeEntite;
        }
    }
}
