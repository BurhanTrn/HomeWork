namespace Arrays_HomeWork;

class Program
{
    static void Main(string[] args)
    {
        #region Soru1:
        // 10 elemanlı rastgele değerlerden oluşan bir tam sayı dizisi içinde, dizinin her bir elemanının yalnızca bir önceki ve bir sonraki elemanı ile kıyaslandığı bir algoritma yazın. Bu algoritma, yalnızca kendinden önceki sayı ve kendinden sonraki sayı büyük olan elemanları bulmalı ve bunları ekrana yazdırmalıdır.
        // int[] sayılar = { 3, 5, 2, 8, 4, 15, 20, 11, 12, 9 };

        // for (int i = 1; i < sayılar.Length - 1; i++)
        // {
        //     if (sayılar[i] > sayılar[i - 1] && sayılar[i] > sayılar[i + 1])
        //     {
        //         System.Console.WriteLine($"{sayılar[i]} sağındaki ve solundaki sayılardan büyüktür!");
        //     }
        // // }


        #region soru2
        // int[] dizi = new int[10];
        // int[] ciftDizi = new int[10];
        // int sayaç = 0;
        // System.Console.WriteLine("10 adet sayı giriniz = ");

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     while (!int.TryParse(Console.ReadLine(), out dizi[i]))
        //     {
        //         System.Console.WriteLine("geçerli sayı giriniz");
        //     }
        // }

        // System.Console.WriteLine("------------------------------------------------");

        // foreach (var sayı in dizi)
        // {
        //     System.Console.WriteLine(sayı);
        // }

        // for (int i = 0; i < 10; i++)
        // {
        //     if (dizi[i] % 2 == 0)
        //     {
        //         ciftDizi[sayaç] = dizi[i];
        //         sayaç++;

        //     }

        // }

        // Array.Sort(ciftDizi);
        // System.Console.WriteLine("Çiftve küçükten büyüğe sıralı dizilerim ");
        // foreach (var item in ciftDizi)
        // {
        //     System.Console.WriteLine(item);
        // }

        // int[] sayilar = new int[10];
        // int[] ciftSayilar = new int[10];
        // int ciftIndex = 0;

        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine("Bir sayı giriniz:");
        //     sayilar[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // for (int i = 0; i < 10; i++)
        // {
        //     if (sayilar[i] % 2 == 0)
        //     {
        //         ciftSayilar[ciftIndex] = sayilar[i];
        //         ciftIndex++;
        //     }
        // }
        // Array.Sort(ciftSayilar, 0, ciftIndex);
        // Console.WriteLine("Çift Sayılar(sıralı):");
        // for (int i = 0; i < ciftIndex; i++)
        // {
        //     Console.Write(ciftSayilar[i] + " ");
        // }

        #endregion


        #endregion

        #region Arrays-soru3:
        // 10 elemanlı rastgele değerlerden oluşan bir dizideki tüm pozitif sayıları ve negatif sayıları ayrı dizilere ayıran ve her iki diziyi de ekrana yazdıran bir program yazın.İşlemi gerçekleştirmek için `while` döngüsü kullanın.

        // Random rnd = new Random();
        // int[] sayılar = new int[10];
        // int[] pozitifSayılar = new int[10];
        // int[] negatifSayılar = new int[10];
        // int sayac = 0;

        // for (int i = 0; i < sayılar.Length; i++)
        // {
        //     sayılar[i] = rnd.Next(-10, 20);
        //     System.Console.WriteLine(sayılar[i]);
        // }



        // for (int i = 0; i < sayılar.Length; i++)
        // {
        //     if (sayılar[i] < 0)
        //     {
        //         negatifSayılar[sayac] = sayılar[i];
        //         sayac++;
        //     }

        //     else
        //     {
        //         pozitifSayılar[sayac] = sayılar[i];
        //         sayac++;
        //     }

        // }

        // System.Console.WriteLine("Negatif Sayılar: ");
        // foreach (var ngtf in negatifSayılar)
        // {
        //     System.Console.WriteLine(ngtf);
        // }
        // System.Console.WriteLine("Pozitif Sayılar: ");
        // foreach (var pztf in pozitifSayılar)
        // {
        //     System.Console.WriteLine(pztf);
        // }








        #endregion

        #region Arrays-Soru4:
        // 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde tekrar eden elemanları bulan bir program yazın.Diziyi tararken, elemanların hangi 
        // pozisyonlarda(kaçıncı indexte) tekrarlandığını ekrana yazdırın.Bu işlemi hem `for` hem de `foreach` döngüleri ile gerçekleştirin.

        // Random rnd = new Random();
        // int[] sayılar = new int[25];
        // int sayac = 0;

        // for (int i = 0; i < sayılar.Length; i++)
        // {
        //     sayılar[i] = rnd.Next(1, 50);


        // }
        // foreach (var sayılarYaz in sayılar)
        // {
        //     System.Console.WriteLine($"index {sayac}. sayı={sayılarYaz}");
        //     sayac++;
        // }

        // for (int i = 0; i < sayılar.Length; i++)
        // {
        //     for (int j = i + 1; j < sayılar.Length; j++)
        //     {
        //         if (sayılar[i] == sayılar[j])
        //         {
        //             System.Console.WriteLine($"{i}.index ve {j}.indexte Sayı {sayılar[i]}  tekrar ediyor");
        //         }
        //     }
        // }
        #endregion

        #region Arrays-Soru5:
        // Klavyeden girilen bir sayının, 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde olup olmadığını kontrol eden bir algoritma yazın.Eğer sayı 
        // dizide varsa, sayının dizideki yerini ve tekrar sayısını ekrana yazdırın.

        // Random rnd = new Random();
        // int[] sayılar = new int[25];
        // int sayac = 0;
        // int sayac1 = 0;


        // for (int i = 0; i < sayılar.Length; i++)
        // {
        //     sayılar[i] = rnd.Next(1, 10);
        // }

        // foreach (var sayılarDizi in sayılar)
        // {
        //     System.Console.WriteLine($"{sayac}.index sayı {sayılarDizi}");
        //     sayac++;

        // }

        // System.Console.Write("Lütfen Bir Sayı Giriniz: ");
        // int alınanVeri = int.Parse(Console.ReadLine());

        // for (int i = 0; i < sayılar.Length; i++)
        // {
        //     if (sayılar[i] == alınanVeri)
        //     {
        //         System.Console.WriteLine($"Girdiğiniz {sayılar[i]} sayısı {i}.indexte ");

        //         sayac1++;
        //     }
        // }

        // System.Console.WriteLine($" girdiğiniz veri {sayac1} kere tekarar ediyor.");

        #endregion

        #region Arrays-Soru6:
        // 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde en büyük ve en küçük sayıyı bulan programı yazın.

        // Random rnd = new Random();
        // int[] sayılar = new int[25];
        // int sayac = 0;

        // for (int i = 0; i < sayılar.Length; i++)
        // {
        //     sayılar[i] = rnd.Next(0, 50);
        //     System.Console.WriteLine(sayılar[i]);
        // }

        // int max = int.MinValue;
        // int min = int.MaxValue;

        // foreach (var enBenK in sayılar)
        // {
        //     if (enBenK > max) max = enBenK;
        //     if (enBenK < min) min = enBenK;
        // }
        // System.Console.WriteLine($"En Büyük Sayı: {max}  En Küçük Sayı:{min}");
        #endregion

        #region Arrays-Soru7:
        // 50 elemanlı rastgele değerlerden oluşan bir tam sayı dizisindeki tüm çift sayıları toplayan ve bu toplamı ekrana yazdıran bir program yazın. `foreach` döngüsü kullanarak bu işlemi gerçekleştirin.

        // Random rnd = new Random();
        // int[] sayılar = new int[25];
        // int ciftSayılar = 0;
        // int sonuc = 0;

        // for (int i = 0; i < sayılar.Length; i++)
        // {
        //     sayılar[i] = rnd.Next(1, 100);
        //     System.Console.WriteLine(sayılar[i]);
        // }

        // foreach (var sayılarYazdır in sayılar)
        // {
        //     if (sayılarYazdır % 2 == 0)
        //     {
        //         ciftSayılar += sayılarYazdır;
        //     }
        // }
        // System.Console.WriteLine($"Random atanan sayıların çif sayıları toplamı={ciftSayılar}");
        #endregion

        #region Arrays-Soru8(Duygu Hocaya Sor):
        // Klavyeden girilen bir sayıyı, 10 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde aratın.Eğer sayı dizide yoksa, diziyi sıralayın ve sayıyı dizinin doğru(olması gereken sıra) yerine ekleyin. Ekledikten sonra yeni diziyi ekrana yazdırın.  

        // Random random = new Random();
        // int[] dizi = new int[10];
        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     dizi[i] = random.Next(10);
        // }
        // Console.WriteLine("Dizi: " + string.Join(", ", dizi));
        // Console.WriteLine("Bir sayı giriniz:");
        // int sayi = Convert.ToInt32(Console.ReadLine());
        // bool varMi = false;

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     if (dizi[i] == sayi)
        //     {
        //         varMi = true;
        //         break;
        //     }
        // }
        // if (varMi)
        // {
        //     Console.WriteLine("Sayı Dizide Bulundu..");
        // }
        // else
        // {
        //     Console.WriteLine("Sayı Dizide Bulunamadı,Ekliyoruz");
        //     Array.Sort(dizi);

        //     int[] yeniDizi = new int[dizi.Length + 1];
        //     bool eklendi = false;
        //     int j = 0; //Yeni dizinin index başlangıç değeri

        //     for (int i = 0; i < dizi.Length; i++)
        //     {
        //         if (!eklendi && sayi < dizi[i])
        //         {
        //             yeniDizi[i] = sayi;
        //             eklendi = true;
        //             j++;
        //         }
        //         yeniDizi[j] = dizi[i];
        //         j++;
        //     }

        //     if (!eklendi)
        //     {
        //         yeniDizi[j] = sayi;
        //     }
        //     Console.WriteLine("Yeni Dizi:");
        //     foreach (int i in dizi)
        //     {
        //         Console.WriteLine(i + ",");
        //     }
        // }



        #endregion

        #region Arrays-Soru9:
        // Verilen bir dizinin yalnızca pozitif sayılarını ters çeviren bir algoritma yazın.Diziyi tararken, sadece pozitif sayıların yerini değiştirmelisiniz, diğer elemanlar aynı kalmalı.

        // int[] sayılar = [5, -7, 8, 3, -2, 10, 7, -9, 10];
        // for (int i = 0; i < sayılar.Length; i++)
        // {
        //     if (sayılar[i] > 0)
        //     {
        //         sayılar[i] = -sayılar[i];

        //     }
        // }
        // foreach (var x in sayılar)
        // {
        //     System.Console.WriteLine(x);

        // }
        #endregion

        #region Arrays-Soru10:
        // 10 elemanlı bir dizi oluşturun ve bu dizinin elemanlarını bir başka diziye ters sırada kopyalayın. İlk dizideki sıralama değişmeyecek, sadece ikinci dizideki sıralama ters olacak.

        // string[] girilenVeri =
        // {
        //         "Burhan",
        //         "Samet",
        //         "Burak",
        //         "Uğur",

        // };

        // System.Console.WriteLine("Bu Dizinin Orjinal Hali: ");

        // foreach (var x in girilenVeri)
        // {
        //     System.Console.WriteLine(x);
        // }

        // Array.Reverse(girilenVeri);
        // string[] degistirilmisMetin = new string[girilenVeri.Length];
        // Array.Copy(girilenVeri, degistirilmisMetin, girilenVeri.Length);

        // System.Console.WriteLine("Dizinin Ters Çevrilmiş Yeni Dizi Hali: ");

        // foreach (var y in degistirilmisMetin)
        // {
        //     System.Console.WriteLine(y);
        // }

        //Duygu hocanın yaptığı:

        // int[] dizi = { 1, 4, 7, 21, 33, 5, 667, 43, 66, 22 };
        // int j = 0;
        // int[] result = new int[dizi.Length];
        // for (int i = result.Length - 1; i >= 0; i--)
        // {
        //     result[j] = dizi[i];
        //     j++;
        // }
        // for (int i = 0; i < result.Length; i++)
        // {
        //     Console.Write(result[i] + ",");
        // }
        // Console.WriteLine("Dizinin orijinal hali:");
        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     Console.Write(dizi[i] + ",");
        // }
        // Console.Read();






        #endregion

        #region Arrays-Soru11:
        // Klavyeden girilen bir cümlenin kelimelerini bir diziye aktarın. `while` döngüsü ile bu kelimeleri tersten ekrana yazdırın.

        // System.Console.WriteLine("Lütfen Bir Cümle Giriniz: ");
        // string alınanCumle = Console.ReadLine();
        // string[] yeniDizi = alınanCumle.Split(' ');
        // int index = yeniDizi.Length - 1;

        // while (index >= 0)
        // {
        //     System.Console.WriteLine(yeniDizi[index]);
        //     index--;
        // }

        #endregion

        #region Arrays-Soru12:
        // 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde en sık tekrar eden elemanı bulan ve kaç defa tekrarlandığını ekrana yazdıran bir program yazın.Bu işlemi bir `foreach` döngüsü ile gerçekleştirin.
        // Random rnd = new Random();
        // int[] sayılar = new int[15];

        // for (int i = 0; i < sayılar.Length; i++)
        // {
        //     sayılar[i] = rnd.Next(1, 7);
        //     System.Console.WriteLine(sayılar[i]);

        // }

        // Dictionary<int, int> frekans = new Dictionary<int, int>();

        // foreach (var sayı in sayılar)
        // {
        //     if (frekans.ContainsKey(sayı))
        //     {
        //         frekans[sayı]++;

        //     }

        //     else
        //     {
        //         frekans[sayı] = 1;
        //     }
        // }

        // int enSikTekrarEdenSayi = -1;
        // int tekrarSayisi = 0;

        // foreach (KeyValuePair<int, int> anahtarDeger in frekans)
        // {
        //     if (anahtarDeger.Value > tekrarSayisi)
        //     {
        //         tekrarSayisi = anahtarDeger.Value;
        //         enSikTekrarEdenSayi = anahtarDeger.Key;
        //     }
        // }

        // System.Console.WriteLine($"En sık tekrar eden sayı: {enSikTekrarEdenSayi}");
        // System.Console.WriteLine($"Tekrar sayısı: {tekrarSayisi}");

        #endregion


        #region Soru13:
        // Bir dizideki tek sayıları toplayan ve bu toplamın çift mi, tek mi olduğunu kontrol eden bir program yazın.Toplamla birlikte eğer toplam tek ise, "Toplam tek sayı" mesajı, çift ise "Toplam çift sayı" mesajı ekrana yazdırılmalı.

        // Random rnd = new Random();
        // int[] sayılar = new int[10];
        // int toplam = 0;
        // for (int i = 0; i < sayılar.Length; i++)
        // {
        //     sayılar[i] = rnd.Next(1, 11);
        //     System.Console.WriteLine(sayılar[i]);
        // }

        // for (int i = 0; i < sayılar.Length; i++)
        // {
        //     if (sayılar[i] % 2 != 0)
        //     {
        //         toplam += sayılar[i];
        //     }
        // }

        // if (toplam % 2 == 0)
        // {
        //     System.Console.WriteLine($"Random atanan tek sayıların toplamının sonucu çifttir= {toplam}");
        // }

        // else
        // {
        //     System.Console.WriteLine($"Random atanan tek sayıların toplamının sonucu tektir= {toplam}");
        // }
        #endregion

        #region Soru14:
        // 20 elemanlı bir dizi oluşturun. Bu dizideki elemanların 3’e bölünebilenlerin toplamını bulan bir algoritma yazın.Sonucu ekrana yazdırırken her 5.elemandan sonra bir boşluk bırakın.

        // int[] sayılar = { 3, 9, 6, 15, 8, 15, 7, 6, 10, 8, 11, 12, 15, 16, 17, 16, 17, 18, 19, 21 };
        // int toplam = 0;
        // System.Console.WriteLine("Dizinin elemanları");
        // for (int i = 0; i < sayılar.Length; i++)
        // {
        //     System.Console.Write(sayılar[i] + " ");
        // }
        // System.Console.WriteLine();

        // for (int i = 0; i < sayılar.Length; i++)
        // {
        //     if (sayılar[i] % 3 == 0)
        //     {
        //         toplam += sayılar[i];
        //     }
        // }
        // int elemanSayisi = 0;
        // System.Console.WriteLine("3'e bölünebilen elamanlar");
        // for (int i = 0; i < sayılar.Length; i++)
        // {
        //     if (sayılar[i] % 3 == 0)
        //     {
        //         System.Console.Write(sayılar[i] + " ");
        //         elemanSayisi++;
        //     }
        //     if (elemanSayisi % 5 == 0)
        //     {
        //         System.Console.Write(" ");
        //     }
        // }
        // System.Console.WriteLine();
        // System.Console.WriteLine($"3'e Bölünebilen elemanlar toplamı: {toplam}");


        #endregion

        #region Soru15:
        // Bir dizideki elemanları küçükten büyüğe sıralayan bir algoritma yazın.Ancak sıralama sırasında sadece tek sayılar sıralanmalı, çift sayılar yerlerinde kalmalıdır.

        int[] dizi = { 2, 5, 9, 10, 7, 8, 5 };

        int teksayıadet = 0;


        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] % 2 != 0)
            {
                teksayıadet++;
            }
        }

        int[] tekdizi = new int[teksayıadet];

        int index = 0;

        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] % 2 != 0)
            {
                tekdizi[index] = dizi[i];
                index++;
            }
        }

        Array.Sort(tekdizi);

        int index2 = 0;
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] % 2 != 0)
            {
                dizi[i] = tekdizi[index2];
                index2++;
            }
        }

        foreach (var item in dizi)
        {
            System.Console.WriteLine(item);
        }


        #endregion

    }
}
