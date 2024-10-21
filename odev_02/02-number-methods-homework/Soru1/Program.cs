namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan alınan bir ondalıklı sayıyı en yakın tam sayıya yuvarlayan bir program yazın.


        System.Console.Write("Lütfen Ondalıklı Bir Sayı Giriniz: ");
        double alınanDeger = double.Parse(Console.ReadLine());

        double sonDeger = Math.Round(alınanDeger);
        System.Console.WriteLine($"Girdiğiniz Ondalıklı Sayı: {alınanDeger}\nTam Sayı Yuvarlaması: {sonDeger}");

    }
}
