using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AtvaltOOP;

[TestFixture]
public class AtvaltTests
{
    [Test]
    public void Test_BinToDecimal()
    {
        // Bináris szám átváltása tizes számrendszerbe
        var atvalt = new Atvalt("1011");
        Assert.AreEqual("11", atvalt.Eredmeny());
    }

    [Test]
    public void Test_DecimalToBin()
    {
        // Tizes szám átváltása bináris számrendszerbe
        var atvalt = new Atvalt("11");
        Assert.AreEqual("1011", atvalt.Eredmeny());
    }

    [Test]
    public void Test_InvalidInput()
    {
        // Hibás adatbevitel (nem bináris és nem tizes szám)

        // Az Assert.Throws metódus használata a megfelelő szintaxissal
        var ex = Assert.Throws<FormatException>(() => new Atvalt("12").Eredmeny());
        Assert.That(ex.Message, Is.EqualTo("Hibás adat: A szám nem bináris vagy tizes szám."));

        ex = Assert.Throws<FormatException>(() => new Atvalt("abc").Eredmeny());
        Assert.That(ex.Message, Is.EqualTo("Hibás adat: A szám nem bináris vagy tizes szám."));

        ex = Assert.Throws<FormatException>(() => new Atvalt("1012").Eredmeny());
        Assert.That(ex.Message, Is.EqualTo("Hibás adat: A szám nem bináris vagy tizes szám."));
    }
}