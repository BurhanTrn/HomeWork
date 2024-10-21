namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan alınan üç sayıdan en büyüğünü bulan bir program yazın.

        System.Console.Write("1.Sayıyı Giriniz: ");
        double sayi1 = double.Parse(Console.ReadLine());

        System.Console.Write("2.Sayıyı Giriniz: ");
        double sayi2 = double.Parse(Console.ReadLine());

        System.Console.Write("3.Sayıyı Giriniz: ");
        double sayi3 = double.Parse(Console.ReadLine());

        double enBuyukSayi;

        if (sayi1 >= sayi2 && sayi1 >= sayi3)
        {
            enBuyukSayi = sayi1;
        }

        else if (sayi2 >= sayi1 && sayi2 >= sayi3)
        {
            enBuyukSayi = sayi2;
        }

        else
        {
            enBuyukSayi = sayi3;
        }

        System.Console.WriteLine($"Girdiğiniz En Büyük Sayı: {enBuyukSayi}");

    }
}
