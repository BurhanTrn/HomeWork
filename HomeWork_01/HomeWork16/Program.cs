namespace HomeWork16;

class Program
{
    static void Main(string[] args)
    {
        #region Soru 16:

        // double` tipinde pi sayısını temsil eden bir değişken oluşturun(3.14159). Bu değeri `float` tipine dönüştürüp yeni bir değişkene atayın. Her iki değeri de ekrana yazdırıp hassasiyet farkını gözlemleyin.

        #endregion

        double deger = 3.14159;
        float newDeger = (float)deger;
        System.Console.WriteLine(deger);
        System.Console.WriteLine(newDeger);

        double pi = 3.1415926535;
        float newPi = (float)pi;
        System.Console.WriteLine(pi);
        System.Console.WriteLine(newPi);

        #region Açıklama: 

        // İlk örnekte basamak hassasiyetinden dolayı herhangi bir sorun yaşanmazken ikinci örnekte basamak sayısı arttığı için basamak hassasiyeti değişmiştir ve 7. basamak farklı çıktı vermiştir. Veri tiplerinin doğru yerde doğru şekilde kullanılmasının önemi ortaya çıkmıştır.Banka işlemlerinde yapılacak tek bir basamak hatası yüksek hacimli işlemlerde tarafları büyük zararlara uğratabilir.
            
        #endregion



    }
}
