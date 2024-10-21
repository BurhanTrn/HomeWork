namespace Soru8;

class Program
{
    static void Main(string[] args)
    {

        // Soru8 : Kullanıcıdan alınan bir sayının 3'e ve 5'e tam bölünüp bölünmediğini kontrol eden ve uygun mesajı veren bir program yazın.

        Console.Write("Lütfen Bir Sayı Giriniz: ");
        double sayi = double.Parse(Console.ReadLine());

        if (sayi % 3 == 0 && sayi % 5 == 0)
        {
            System.Console.WriteLine($"Girdiğiniz {sayi} Sayısı 3'e ve 5'e Tam Bölünmüştür.");
        }

        else if (sayi % 3 == 0)
        {
            System.Console.WriteLine($"Girdiğiniz {sayi} Sayısı 3'e Tam Bölünmüştür.");
        }

        else if (sayi % 5 == 0)
        {
            System.Console.WriteLine($"Girdiğiniz {sayi} Sayısı  5'e Tam Bölünmüştür.");
        }

        else
        {
            System.Console.WriteLine($"Girdiğiniz {sayi} Sayısı 3'e ve 5'e Tam olarak Bölünememiştir.");
        }




    }
}
