using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.Model;

namespace Zoom.DAL.Gestionnaire
{
    /**
     * Classe static gestionnaire de toutes les entités de notre zoo
     */ 
    public class GEntite<T> where T : IEntite
    {
        private static int id = 0;

        private static List<T> listeEntite = new List<T>();

        public static List<T> ListeEntite
        {
            get { return listeEntite; }
            set { listeEntite  = value; }
        }

        public static int Create(Type type, Object[] parameters)
        {
            Object[] newParam = new Object[parameters.Length+1] ;
            newParam[0] = AssigneID();
            parameters.CopyTo(newParam, 1);
            try
            {
                T entite = (T)Activator.CreateInstance(type, newParam);
                Add(entite);
                return entite.Id;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static T Add(T entite)
        {
            listeEntite.Add(entite);
            Type t = entite.GetType();
            return entite;
        }

        public static void Remove(T entite)
        {
            listeEntite.Remove(entite);
        }

        public static T GetOnebyID(int id)
        {
            return ListeEntite.Find(x=> x.Id == id);
        }

        public static List<T> GetAll()
        {
            return ListeEntite;
        }

        public static int AssigneID()
        {
            var idOld = id;
            id++;
            return idOld;
        }
    }
}
