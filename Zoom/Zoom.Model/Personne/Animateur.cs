﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.Model.Animal;
using Zoom.Model.Personne.Interface;

namespace Zoom.Model.Personne
{
    public class Animateur : Employe, INourrir, IEntite
    {
        public Animateur(int id, string nom, string prenom, ESexe sexe) : base(id, nom, prenom, sexe)
        {
        }

        public Animateur(int id, string nom, string prenom, ESexe sexe, DateTime dateNaissance) : base(id, nom, prenom, sexe, dateNaissance)
        {
        }

        public void Nourrir(AAnimal a)
        {
            throw new NotImplementedException();
        }
        public void Animer()
        {
            throw new NotImplementedException();
        }
    }
}