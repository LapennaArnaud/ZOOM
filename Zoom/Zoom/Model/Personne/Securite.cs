using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.BLL.Model.Structure;

namespace Zoom.BLL.Model.Personne
{
    public class Securite : Employe
    {
        public Securite(int id, string nom, string prenom, ESexe sexe) : base(id, nom, prenom, sexe)
        {
        }

        public Securite(int id, string nom, string prenom, ESexe sexe, DateTime dateNaissance) : base(id, nom, prenom, sexe, dateNaissance)
        {
        }

        public void JeterDehors(APersonne P)
        {
            throw new NotImplementedException();
        }

        public void Securise(AStructure P)
        {
            throw new NotImplementedException();
        }
    }
}
