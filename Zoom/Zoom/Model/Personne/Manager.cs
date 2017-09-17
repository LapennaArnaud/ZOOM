using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom.BLL.Model.Personne
{
    public class Manager : Employe
    {
        public List<Employe> ListEmploye { get; set; } = new List<Employe>();

        public Manager(int id, string nom, string prenom, ESexe sexe) : base(id, nom, prenom, sexe)
        {
        }

        public Manager(int id, string nom, string prenom, ESexe sexe, DateTime dateNaissance) : base(id, nom, prenom, sexe, dateNaissance)
        {
        }

    }
}
