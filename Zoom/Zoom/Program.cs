using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoom.Business.Model.Animal;

namespace Zoom
{
    class Program
    {
        static void Main(string[] args)
        {
            AAnimal banane = new Dauphin("Flipper",Sexe.Femelle);
            Console.WriteLine(banane.ToString());
            Console.ReadLine();
        }
    }
}
