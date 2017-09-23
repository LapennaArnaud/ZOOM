using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Zoom.Model.Animal;
using static Zoom.Model.Animal.AAnimal;
using Zoom.BLL.Service;
using Zoom.Model.Aliment;
using Zoom.Model.Structure;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestZoom
{
    [TestClass]
    public class TestAnimal
    {
        [TestMethod]
        public void TestMethod1()
        {
            //AAnimal banane = new Dauphin("Flipper", ESexe.Femelle);
            //Assert.AreEqual(banane.Nom, "Flipper");
            //Console.WriteLine(banane.ToString());

            BaseService.Creer(typeof(Cereale), new object[] { "blé" });

            BaseService.Creer(typeof(Stock), new object[] { "Stock1", 10, 10 });

            Console.WriteLine(BaseService.AfficherAll() + "\n\r");

            Console.WriteLine(S_Aliment.AfficherAll() + "\n\r");

            Console.WriteLine(S_Structure.AfficherAll() + "\n\r");

            Stock s = (Stock)BaseService.GetOnebyID(7);
            AAliment al = (AAliment)BaseService.GetOnebyID(6);

            s.ListeAliment.Add(al, 10);

            BaseService.Supprimer(BaseService.GetOnebyID(6));

            Console.WriteLine(S_Structure.AfficherAll() + "\n\r");
            List<AAliment> aa = s.ListeAliment.Keys.ToList();
            s.ListeAliment.Keys.ToList().ForEach(Console.WriteLine);

        }


    }


}
