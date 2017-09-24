using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.DAL.Gestionnaire;
using Zoom.Model;
using Zoom.Model.Aliment;

namespace Zoom.BLL.Service
{
    public class S_Aliment : BaseService
    {
        public new static List<IEntite> GetAll()
        {
            return GEntite<IEntite>.GetAll().FindAll(x => x is AAliment);
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
