﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom.BLL.Model.Personne
{
    public class Employe : APersonne
    {
        public DateTime DateNaissance { get; set; }

        public Employe(int id, string nom, string prenom, ESexe sexe) : base(id, nom, prenom, sexe)
        {
            DateNaissance = DateTime.Now;
        }

        public Employe(int id, string nom, string prenom, ESexe sexe, DateTime dateNaissance) : base(id, nom, prenom, sexe)
        {
            DateNaissance = dateNaissance;
        }

        public int CalculAge()
        {
            return (DateTime.Now.Year - this.DateNaissance.Year);
        }

        public override string ToString()
        {
            string determinant = (this.Sexe == ESexe.Femme ? "e" : "");
            return base.ToString() + string.Format(" né{0} en {1}", determinant, this.DateNaissance);
        }


    }
}
