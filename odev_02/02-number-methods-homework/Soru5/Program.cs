namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        // Soru5: Kullanıcıdan alınan iki sayı için üs alma işlemi yapan bir program yazın(örneğin, 2 ^ 3).

        System.Console.Write("Üs sayısını öğrenmek istediğiniz ilk sayıyı giriniz : ");
        double ilkSayi = double.Parse(Console.ReadLine());

        System.Console.Write("Üs kuvvetini giriniz: ");
        double ikinciSayi = double.Parse(Console.ReadLine());

        double sonuc = Math.Pow(ilkSayi, ikinciSayi);
        System.Console.WriteLine(sonuc);

    }
}
