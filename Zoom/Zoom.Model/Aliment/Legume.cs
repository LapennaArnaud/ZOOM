﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom.Model.Aliment
{
    public class Legume : AAliment, IEntite
    {
        public Legume(int id, string nom) : base(id, nom)
        {

        }
    }
}
