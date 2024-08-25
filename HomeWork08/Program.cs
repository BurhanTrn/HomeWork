namespace HomeWork08;

class Program
{
    static void Main(string[] args)
    {
        #region Soru 08:

        // `double` tipinde bir değişken oluşturun ve içine 3.14 değerini atayın. Bu değeri `int` tipine dönüştürüp yeni bir değişkene atayın ve sonucu ekrana yazdırın. Sonucu yorumlayın.

        #endregion

        double deger = 3.14;
        int newDeger = (int)deger;
        System.Console.WriteLine(newDeger);

        #region Açıklama: 
        // Double değişken türü 16 basamak hassasiyeti olan ondalıklı sayı veri türüdür. Double değişkeni int veri tipine dönüştürdüğümüzde basamak kısmı atılır,çünkü int değişkeni tamsayı değişken türüdür.

        #endregion

    }
}
