namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        // Soru2: Kullanıcıdan alınan üç sayıyı büyükten küçüğe sıralayan bir program yazın.

        System.Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
        int sayi1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
        int sayi2 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Lütfen üçüncü sayıyı giriniz: ");
        int sayi3 = int.Parse(Console.ReadLine());
        int enBuyuk, orta, enKucuk;

        if (sayi1 >= sayi2 && sayi1 >= sayi3)
        {
            enBuyuk = sayi1;
            orta = Math.Max(sayi2, sayi3);
            enKucuk = Math.Min(sayi2, sayi3);
        }
        else if (sayi2 >= sayi1 && sayi2 >= sayi3)
        {
            enBuyuk = sayi2;
            orta = Math.Max(sayi1, sayi3);
            enKucuk = Math.Min(sayi1, sayi3);
        }
        else
        {
            enBuyuk = sayi3;
            orta = Math.Max(sayi1, sayi2);
            enKucuk = Math.Min(sayi1, sayi2);
        }


        Console.WriteLine("Büyükten küçüğe sıralama: " + enBuyuk + ", " + orta + ", " + enKucuk);









    }
}
