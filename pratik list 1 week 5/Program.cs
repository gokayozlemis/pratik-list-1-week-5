using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Console.WriteLine("** DAVETLİLERRR **");

        List<string> ziyaretciListesi = new List<string> { "Bülent ERSOY", "Ajda PEKKAN", "Ebru GÜNDEŞ", "Hadise", "Hande YENER","Tarkan","Funda ARAR","Demet AKALIN"};

        foreach (string isim in ziyaretciListesi)
        {
            Console.WriteLine(isim);
        }

        for (int i = 0; i < ziyaretciListesi.Count; i++)
        {
            Console.WriteLine(ziyaretciListesi[i]);
        }
    }
}
