namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan alınan iki sayıdan hangisinin daha büyük olduğunu bulan bir program yazın.

        System.Console.Write("Lütfen ilk sayıyı giriniz: ");
        int ilkDeger = int.Parse(Console.ReadLine());

        System.Console.Write("Lütfen ikinci sayıyı giriniz: ");
        int ikinciDeger = int.Parse(Console.ReadLine());

        int enBuyukSayi = Math.Max(ilkDeger, ikinciDeger);


        if (ilkDeger == ikinciDeger)
        {
            Console.WriteLine("Her iki sayı da eşittir.");
        }
        else
        {
            Console.WriteLine("En büyük sayı: {0}", enBuyukSayi);
        }



        {

        }




    }
}
