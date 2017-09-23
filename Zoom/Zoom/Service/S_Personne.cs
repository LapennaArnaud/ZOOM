using System;
using System.Collections.Generic;
using Zoom.DAL.Gestionnaire;
using Zoom.Model;
using Zoom.Model.Personne;

namespace Zoom.BLL.Service
{
    public class S_Personne : BaseService
    {
        public static int CalculAge(Employe employe)
        {
            return (DateTime.Now.Year - employe.DateNaissance.Year);
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
