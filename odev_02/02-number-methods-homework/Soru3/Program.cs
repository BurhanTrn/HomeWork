namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        // Soru3: Kullanıcıdan alınan bir sayının mutlak değerini hesaplayan bir program yazın.

        System.Console.Write("Lütfen Bir Sayı Giriniz: ");
        int alınanDeger = int.Parse(Console.ReadLine());

        int sonDeger = Math.Abs(alınanDeger);

        System.Console.WriteLine($"Girdiğiniz sayı: {alınanDeger} Girdiğiniz sayının mutlak değeri: {sonDeger}");







    }
}
