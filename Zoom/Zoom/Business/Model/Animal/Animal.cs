using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom.Model.Animal
{
    public abstract class Animal
    {
        private string nom { get; set; }

        public DateTime date_naissance { get; set; }

        public abstract void manger();



    }
}
