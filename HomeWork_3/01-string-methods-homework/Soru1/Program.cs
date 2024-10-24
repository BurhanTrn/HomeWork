namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        // Soru 1: Kullanıcıdan alınan bir cümledeki kelime sayısını bulan bir program yazın. (Split metodunu araştırınız.)



        System.Console.Write("Lütfen bir cümle yazınız: ");
        string metin = Console.ReadLine();

        string[] dize = metin.Split(' ');

        System.Console.WriteLine("Toplam Girdiğiniz Kelime Sayısı: " + dize.Length);

    }
}
