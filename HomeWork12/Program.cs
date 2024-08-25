namespace HomeWork12;

class Program
{
    static void Main(string[] args)
    {
        #region Soru 12:

        // `float` tipinde bir değişken oluşturun ve içine 1.23f değerini atayın. Bu değeri `double` tipine dönüştürüp yeni bir değişkene atayın. İki değeri de ekrana yazdırıp karşılaştırın.

        #endregion

        float sayi = 1.23f;
        double newSayi = (double)sayi;
        System.Console.WriteLine(sayi);
        System.Console.WriteLine(newSayi);

        #region Açıklama:
        // Basamak hassasiyeti yüksek olan double veri türü daha doğru ve kapsamlı bir sonuç verdi.

        #endregion

    }
}
