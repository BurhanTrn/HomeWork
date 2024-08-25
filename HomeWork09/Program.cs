namespace HomeWork09;

class Program
{
    static void Main(string[] args)
    {
        #region Soru 09:

        //    `string` tipinde bir değişken oluşturun ve içine bir sayı yazın(örneğin "42").Bu string'i `int` tipine dönüştürüp yeni bir değişkene atayın ve ekrana yazdırın.


        #endregion

        string sayi = "23";
        int yenisayi = Convert.ToInt32(sayi);
        System.Console.WriteLine(yenisayi);

    }

}
