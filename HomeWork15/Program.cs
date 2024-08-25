namespace HomeWork15;

class Program
{
    static void Main(string[] args)
    {
        #region Soru 15:

        // `string` tipinde bir değişken oluşturun ve içine "True" yazın.Bu string'i `bool` tipine dönüştürüp yeni bir değişkene atayın ve ekrana yazdırın.

        #endregion

        string deger = "True";
        bool newDeger = bool.Parse(deger);
        System.Console.WriteLine(newDeger);

    }
}
