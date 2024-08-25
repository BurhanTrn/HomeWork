namespace HomeWork10;

class Program
{
    static void Main(string[] args)
    {
        #region Soru 10:

        // int` tipinde üç değişken oluşturun ve bunlara sırasıyla 5, 10 ve 15 değerlerini atayın. Bu değişkenlerin ortalamasını hesaplayıp `double` tipinde bir değişkene atayın ve sonucu ekrana yazdırın.

        #endregion

        int deger1 = 5;
        int deger2 = 10;
        int deger3 = 15;
        double newDeger = (deger1 + deger2 + deger3) / 3;
        System.Console.WriteLine(newDeger);
    }
}
