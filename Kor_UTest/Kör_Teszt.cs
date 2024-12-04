﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kor;

namespace KöHenger_UnitTest
{
    [TestClass]
    public class Kör_Teszt
    {
        [TestMethod]
        public void Kerület_Teszt()
        {
            // Arrange - Feltételek beállítása
            double sugár = 5;
            Kör kör = new Kör(sugár);
            double vártEredm = 31.42;

            // Act - Végrehajtás
            kör.SetKerület();
            double kapottEredm = kör.GetKerület();

            // Assert - Kiértékelés
            Assert.AreEqual(vártEredm, kapottEredm);
        }

        [TestMethod]
        public void Terület_Teszt()
        {
            // Arrange - Feltételek beállítása
            double sugár = 5;
            Kör kör = new Kör(sugár);
            double vártEredm = 78.5398;
            

            // Act - Végrehajtás
            kör.SetTerület();
            double kapottEredm = kör.GetTerület();
            

            // Assert - Kiértékelés
            Assert.AreEqual(vártEredm, kapottEredm,0.01);

        }
    }
}
