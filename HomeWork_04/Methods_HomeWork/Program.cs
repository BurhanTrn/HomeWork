namespace Methods_HomeWork;

class Program
{
    static string calismaDurumu(int yas) // Soru1:
    {
        if (yas > 65)
        {
            return "Emeklilik Yaşında";
        }

        else
        {
            return "Çalışma Yaşında";
        }
    }

    //----------------------------------------------------------------------------------
    static int enBuyukSayi(int sayi1, int sayi2)// Soru2:
    {
        int buyukSayi = Math.Max(sayi1, sayi2);
        return buyukSayi;
    }
    //----------------------------------------------------------------------------------

    static string tersineCevir(string alınanKelime)//Soru3:
    {
        string tersCevrilmis = "";
        for (int i = alınanKelime.Length - 1; i >= 0; i--)
        {
            tersCevrilmis += alınanKelime[i];
        }
        return tersCevrilmis;
    }
    //----------------------------------------------------------------------------------
    static double sınavNotuHesaplama(double not1, double not2) // Soru4:
    {
        double vize = not1 * 0.4;
        double final = not2 * 0.6;
        double totalNot = vize + final;
        return totalNot;
    }
    //----------------------------------------------------------------------------------
    static string[] buyukHarfeCevır(string[] isimler)// Soru5:
    {
        for (int i = 0; i < isimler.Length; i++)
        {
            isimler[i] = isimler[i].ToUpper();
        }
        return isimler;
    }
    //----------------------------------------------------------------------------------
    static void tekMiCiftMi(int sayi1)//Soru6:
    {
        if (sayi1 % 2 == 0)
        {
            Console.WriteLine("Girdiğiniz sayı çift bir sayıdır!");
        }
        else
        {
            System.Console.WriteLine("Girdiğiniz sayı tek bir sayıdır!");
        }
    }

    //----------------------------------------------------------------------------------

    static string ZamanFormatla(int saat, int dakika, int saniye)//Soru7
    {
        return string.Format("{0:D2}:{1:D2}:{2:D2}", saat, dakika, saniye);
    }

    //----------------------------------------------------------------------------------


    static double santigratDonusturFahrenheit(double santigrat)//Soru8:
    {
        return (santigrat * 9 / 5) + 32;
    }
    //----------------------------------------------------------------------------------

    static int EnKucukSayi(int[] dizi)//Soru9:
    {
        int enKucuk = dizi[0];
        foreach (int sayi in dizi)
        {
            if (sayi < enKucuk)
            {
                enKucuk = sayi;
            }
        }
        return enKucuk;
    }

    //----------------------------------------------------------------------------------

    static int diziSayilariToplami(int[] sayilar)//Soru10
    {
        int toplam = 0;
        for (int i = 0; i < sayilar.Length; i++)
        {
            toplam += sayilar[i];
        }
        return toplam;
    }

    //----------------------------------------------------------------------------------
    static int SesliHarfSayisi(string kelime)//Soru11
    {

        char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü',
        'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };

        int sesliHarfSayisi = 0;


        foreach (char harf in kelime)
        {
            if (Array.Exists(sesliHarfler, element => element == harf))
            {
                sesliHarfSayisi++;
            }
        }
        return sesliHarfSayisi;
    }



    //----------------------------------------------------------------------------------

























    static void Main(string[] args)
    {
        //Soru1:----------------------------
        // string donenMesaj1 = calismaDurumu(70);
        // System.Console.WriteLine(donenMesaj);


        //Soru2:-------------------------------
        // int donenMesaj2 = enBuyukSayi(30, 25);
        // System.Console.WriteLine($"Girdiğiniz sayılardan en büyüğü {donenMesaj2}'dir!");

        // Soru3:---------------------------------
        // string resultMessage = tersineCevir("Ali veli kırkdokuz elli");
        // System.Console.WriteLine(resultMessage);

        // //Soru4:------------------------------------
        // double sınavNotum = sınavNotuHesaplama(50, 50);
        // System.Console.WriteLine($"Sınav Notunuz: {sınavNotum}");

        // Soru5:----------------------------------------------
        // string[] isimler = { "burhan", "kemal", "orhan", "ahmet" };
        // string[] buyukHarfeCevrılenMetın = buyukHarfeCevır(isimler);
        // foreach (var buyukHarfeCevrılenMetın1 in buyukHarfeCevrılenMetın)
        // {
        //     System.Console.WriteLine(buyukHarfeCevrılenMetın1);
        // }

        // //Soru6:--------------------------------------------
        // tekMiCiftMi(7);

        //Soru7:--------------------------------------------------
        // string zaman = ZamanFormatla(14, 30, 45);
        // Console.WriteLine(zaman);

        //Soru8:------------------------------------------------------
        // double santigrat = 38;
        // double fahrenheit = santigratDonusturFahrenheit(santigrat);
        // System.Console.WriteLine($"{santigrat}derece = {fahrenheit} Fahrenheit");

        // //Soru9:---------------------------------------------------------------------
        // int[] sayıDizisi = { 7, 3, 11, 4, 19 };
        // int enKucukSon = EnKucukSayi(sayıDizisi);
        // System.Console.WriteLine($"Girdiğiniz sayılardan {enKucukSon} dizinin en küçüğüdür!");

        //Soru10:---------------------------------------------------------------------

        // int[] sayıDizisi1 = {10,15,30,17,43,55};
        // int toplamSon = diziSayilariToplami(sayıDizisi1);
        // System.Console.WriteLine($"Sayı dizisindeki sayıların toplamı:{toplamSon}");

        //Soru11:----------------------------------------------------------------------------------------------------

        // Console.Write("Bir kelime girin: ");
        // string kelime = Console.ReadLine();

        // int sesliSayisi = SesliHarfSayisi(kelime);
        // Console.WriteLine($"{kelime} kelimesindeki sesli harf sayısı: {sesliSayisi}");



    }
}


