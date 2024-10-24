using System.Runtime.CompilerServices;

namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        // Soru3: Kullanıcıdan alınan bir karakterin sesli harf olup olmadığını kontrol eden bir program yazın. (Veya(`||`) operatörünü araştırınız.)



        Console.Write("Bir karakter girin: ");
        char karakter = Console.ReadLine()[0];


        if (karakter == 'a' || karakter == 'e' || karakter == 'ı' ||
            karakter == 'i' || karakter == 'o' || karakter == 'ö' ||
            karakter == 'u' || karakter == 'ü' ||
            karakter == 'A' || karakter == 'E' || karakter == 'I' ||
            karakter == 'İ' || karakter == 'O' || karakter == 'Ö' ||
            karakter == 'U' || karakter == 'Ü')
        {
            Console.WriteLine("Girdiğiniz karakter sesli harftir.");
        }
        else
        {
            Console.WriteLine("Girdiğiniz karakter sesli harf değildir.");
        }
    }
}
