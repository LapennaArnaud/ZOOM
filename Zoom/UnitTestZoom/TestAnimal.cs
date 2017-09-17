using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Zoom.BLL.Model.Animal;


namespace UnitTestZoom
{
    [TestClass]
    public class TestAnimal
    {
        [TestMethod]
        public void TestMethod1()
        {
            AAnimal banane = new Dauphin("Flipper", Sexe.Femelle);
            Assert.AreEqual(banane.Nom, "Flipper");
            Console.WriteLine(banane.ToString());
            
        } 
    }
}
