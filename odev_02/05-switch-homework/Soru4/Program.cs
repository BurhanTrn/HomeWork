using System.Security.Cryptography;

namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        // Soru4: Kullanıcıdan alınan bir harfe göre sesli veya sessiz harf olduğunu belirleyen bir program yazın.

        Console.Write("Lütfen A-Z veya a-z arasından bir harf giriniz: ");
        string kullanıcıVeri = Console.ReadLine();

        // Girdi yalnızca bir karakter olmalıdır
        if (kullanıcıVeri.Length == 1)
        {
            char harf = kullanıcıVeri[0]; // İlk karakteri al

            // Switch ifadesi ile sesli harfleri kontrol et
            switch (harf)
            {
                case 'a':
                case 'e':
                case 'ı':
                case 'i':
                case 'o':
                case 'ö':
                case 'u':
                case 'ü':
                case 'A':
                case 'E':
                case 'I':
                case 'İ':
                case 'O':
                case 'Ö':
                case 'U':
                case 'Ü':
                    Console.WriteLine("Girdiğiniz harf Türkçe'de sesli harf kategorisindedir!");
                    break;

                default:
                    Console.WriteLine("Girdiğiniz harf Türkçe'de sessiz harf kategorisindedir!");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Lütfen sadece bir harf giriniz.");
        }

    }
}
