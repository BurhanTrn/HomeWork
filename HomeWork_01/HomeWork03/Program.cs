namespace HomeWork03;

class Program
{
    static void Main(string[] args)
    {
        #region Soru 03:
        // `string` tipinde bir değişken oluşturun ve içine adınızı atayın. Sonra `int` tipinde bir değişken oluşturup yaşınızı atayın. Bu iki değişkeni kullanarak "Benim adım [ad] ve ben [yaş] yaşındayım." şeklinde bir cümle oluşturup ekrana yazdırın.

        #endregion


        string adim = "Burhan";
        int yasim = 31;
        System.Console.WriteLine("Benim Adım: " + adim);
        System.Console.WriteLine("Ben {0} yaşındayım", yasim);


    }
}
