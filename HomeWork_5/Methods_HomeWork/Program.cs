using System.Globalization;

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
    static string GetDayOfWeek(string tarih)//Soru12
    {
        DateTime date;


        if (DateTime.TryParse(tarih, out date))
        {

            return date.ToString("dddd", new CultureInfo("tr-TR"));
        }
        else
        {
            return "Geçersiz tarih formatı.";
        }
    }

    //----------------------------------------------------------------------------------

    static int KelimeSay(string metin)
    {

        return metin.Split(new char[] { ' ', '.', '!', '?', ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    //----------------------------------------------------------------------------------


    static int GunSay(DateTime tarih1, DateTime tarih2)
    {

        return (tarih2 - tarih1).Days;
    }


    //----------------------------------------------------------------------------------
    static double OrtalamaHesapla(double[] dizi)
    {
        if (dizi.Length == 0) return 0;

        double toplam = 0;
        foreach (var eleman in dizi)
        {
            toplam += eleman;
        }

        return toplam / dizi.Length;
    }

    //----------------------------------------------------------------------------------
    static bool PalindromMu(string kelime)
    {

        char[] kelimeArray = kelime.ToCharArray();
        Array.Reverse(kelimeArray);
        string tersKelime = new string(kelimeArray);


        return kelime.Equals(tersKelime, StringComparison.OrdinalIgnoreCase);
    }
    //----------------------------------------------------------------------------------
    static int SayiyiSay(List<int> sayilar, int arananSayi)
    {
        int sayac = 0;

        foreach (var sayi in sayilar)
        {
            if (sayi == arananSayi)
            {
                sayac++;
            }
        }

        return sayac;
    }

    //----------------------------------------------------------------------------------
    static string TamIsimGetir(string ad, string soyad)
    {
        return $"{ad} {soyad}";
    }
    //----------------------------------------------------------------------------------
    static List<int> AsalSayilariBul(int baslangic, int bitis)
    {
        List<int> asalSayilar = new List<int>();

        for (int sayi = baslangic; sayi <= bitis; sayi++)
        {
            if (AsalMi(sayi))
            {
                asalSayilar.Add(sayi);
            }
        }

        return asalSayilar;
    }

    static bool AsalMi(int sayi)
    {
        if (sayi < 2) return false;

        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    //----------------------------------------------------------------------------------

    static string Birleştir(string[] kelimeler)
    {
        return string.Join(" ", kelimeler);
    }





















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

        //Soru12:----------------------------------------------------------------------------------------------------

        // string tarih = "2024-10-24";


        // string gun = GetDayOfWeek(tarih);

        // Console.WriteLine($"{tarih} tarihi bir {gun} günüdür.");

        //Soru13:----------------------------------------------------------------------------------------------------

        // string metin = "Merhaba dünya! Merhaba C# programlama.";
        // var kelimeSayisi = KelimeSay(metin);

        // Console.WriteLine($"Kelime Sayısı: {kelimeSayisi}");

        //Soru14:----------------------------------------------------------------------------------------------------

        // DateTime tarih1 = new DateTime(2023, 10, 1);
        // DateTime tarih2 = new DateTime(2023, 10, 24);

        // int gunSayisi = GunSay(tarih1, tarih2);
        // Console.WriteLine($"İki tarih arasındaki gün sayısı: {gunSayisi}");

        //Soru15:----------------------------------------------------------------------------------------------------
        // double[] dizi = { 10.5, 20.0, 30.5, 40.0, 50.5 };
        // double ortalama = OrtalamaHesapla(dizi);

        // Console.WriteLine($"Dizinin ortalaması: {ortalama}");

        //Soru16:----------------------------------------------------------------------------------------------------
        // string kelime = "madam";
        // bool sonuc = PalindromMu(kelime);

        // if (sonuc)
        // {
        //     Console.WriteLine($"{kelime} bir palindromdur.");
        // }
        // else
        // {
        //     Console.WriteLine($"{kelime} bir palindrom değildir.");
        // }

        //Soru17:----------------------------------------------------------------------------------------------------
        // List<int> sayilar = new List<int> { 1, 2, 3, 4, 2, 5, 2, 6 };
        // int arananSayi = 2;
        // int sayiSayisi = SayiyiSay(sayilar, arananSayi);

        // Console.WriteLine($"{arananSayi} sayısı listede {sayiSayisi} defa geçiyor.");

        //Soru18:----------------------------------------------------------------------------------------------------
        // Console.Write("Adınızı girin: ");
        // string ad = Console.ReadLine();

        // Console.Write("Soyadınızı girin: ");
        // string soyad = Console.ReadLine();

        // string tamIsim = TamIsimGetir(ad, soyad);
        // Console.WriteLine($"Tam isminiz: {tamIsim}");

        //Soru19:----------------------------------------------------------------------------------------------------
        // Console.Write("Başlangıç sayısını girin: ");
        // int baslangic = int.Parse(Console.ReadLine());

        // Console.Write("Bitiş sayısını girin: ");
        // int bitis = int.Parse(Console.ReadLine());

        // List<int> asalSayilar = AsalSayilariBul(baslangic, bitis);

        // Console.WriteLine($"Asal sayılar: {string.Join(", ", asalSayilar)}");


        //Soru20:----------------------------------------------------------------------------------------------------
        // string[] kelimeler = { "Merhaba", "dünya", "nasılsın?" };
        // string birlesikString = Birleştir(kelimeler);
        // Console.WriteLine($"Birleştirilmiş String: {birlesikString}");





    }
}


