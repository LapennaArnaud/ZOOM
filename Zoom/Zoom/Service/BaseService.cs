using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.DAL.Gestionnaire;
using Zoom.Model;

namespace Zoom.BLL.Service
{
    public class BaseService
    {
        public static void Creer(Type type, Object[] param)
        {
            GEntite<IEntite>.Create(type, param);
        }

        public static void Supprimer(IEntite item)
        {
            GEntite<IEntite>.Remove(item);
        }


        public static void ModifierPersonne(Type type, Object[] param)
        {
            GEntite<IEntite>.Create(type, param);
        }
        public static List<IEntite> GetAll()
        {
            return GEntite<IEntite>.GetAll().FindAll(x => x is IEntite);
        }

        public static IEntite GetOnebyID(int id)
        {
            return GEntite<IEntite>.GetOnebyID(id);
        }

        public static string AfficherAll()
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
