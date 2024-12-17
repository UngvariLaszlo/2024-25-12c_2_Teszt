using System;

public class Atvalt
{
    public string Szam { get; set; }

    // Konstruktor
    public Atvalt(string szam)
    {
        Szam = szam;
    }

    // Átváltás bináris és tizes számrendszer között
    public string AtvaltSzam()
    {
        if (IsBin(Szam))
        {
            // Bináris számot tizesre konvertálunk
            return Convert.ToInt32(Szam, 2).ToString();
        }
        else if (IsDecimal(Szam))
        {
            // Tizes számot binárisra konvertálunk
            return Convert.ToString(int.Parse(Szam), 2);
        }
        else
        {
            // Hibás adatmegadás
            throw new ArgumentException("Hibás adat: A szám nem bináris vagy tizes szám.");
        }
    }

    // Bináris szám ellenőrzése
    private bool IsBin(string szam)
    {
        foreach (var c in szam)
        {
            if (c != '0' && c != '1')
            {
                return false;
            }
        }
        return true;
    }

    // Tizes szám ellenőrzése
    private bool IsDecimal(string szam)
    {
        return int.TryParse(szam, out _);
    }

    // Eredmény lekérése sztringként
    public string Eredmeny()
    {
        return AtvaltSzam();
    }
}