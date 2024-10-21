namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        // Soru10: Kullanıcıdan iki pozitif tam sayı alın. İlk sayıdan başlayarak ikinci sayıya kadar olan sayıların çarpımını hesaplayan bir program yazın.Sonucu ekrana yazdırın.Örneğin, 3 ve 6 girildiğinde, 3 * 4 * 5 * 6 çarpımı hesaplanmalı ve ekranda gösterilmelidir.


        int sonuc = 1;
        System.Console.Write("1.sayıyı giriniz = ");
        int sayi1 = int.Parse(Console.ReadLine());

        System.Console.Write("1. sayıdan daha büyük bir sayı giriniz  = ");
        int sayi2 = int.Parse(Console.ReadLine());

        for (int i = sayi1; i <= sayi2; i++)
        {
            sonuc *= i;
        }
        System.Console.WriteLine($"sonuc = {sonuc}");


    }
}
