using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using atvalt;
/*
 * Ne felejtsük el, hogy a tesztelt metódusokat public-ra kell állítani! A tesztek lefutása után visszaállíthatók
 */

namespace Atvalt_UnitTest
{
    [TestClass]
    public class Atvalt_ClassUnitTest // Az Teszt osztály nevében jelzem, hogy melyik  osztályt tesztelem
    {
        // Mivel mindegyik teszt az osztály metódusait teszteli, ezért az osztály itt egyszer példányosítható
        Atvalt atvalt = new Atvalt();

        [TestMethod]
        public void iSdecimal_True() // a tesztmetódus nevében jelzem, hogy melyik metódust tesztelem és mire
        {
            // Arrange - Tesztkörnyezet beállítása
            string szoveg = "21";
            bool vartEredm = true,
                kapottEredm = false;

            // Act - A vizsgált metódus végrehajtása
            kapottEredm = atvalt.isDecimal(szoveg);

            // Assert - Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm, vartEredm);
        }

        [TestMethod]
        public void iSdecimal_False()
        {
            string szoveg = "!";
            bool vartEredm = false,
                kapottEredm = true;

            kapottEredm = atvalt.isDecimal(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);
        }

        [TestMethod]
        public void iSbinaris_True()
        {
            string szam = "01010101";
            bool vartEredm = true,
                kapottEredm = false;

            kapottEredm = atvalt.isBinaris(szam);

            Assert.AreEqual(kapottEredm, vartEredm);
        }

        [TestMethod]
        public void iSbinaris_False()
        {
            string szam = "drgrgydthnxtfnxtfm";
            bool vartEredm = false,
                kapottEredm = true;

            kapottEredm = atvalt.isBinaris(szam);

            Assert.AreEqual(kapottEredm, vartEredm);
        }
    }
}
