namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        //   Soru4: Kullanıcıdan alınan bir sayının karekökünü hesaplayan bir program yazın.

        System.Console.Write("Lütfen Bir Sayı Giriniz: ");
        double alınanDeger = double.Parse(Console.ReadLine());

        double sonDeger = Math.Sqrt(alınanDeger);


        System.Console.WriteLine($"Girdiğiniz sayı: {alınanDeger} Girdiğiniz sayının Karekökü:  {sonDeger}");



    }
}
