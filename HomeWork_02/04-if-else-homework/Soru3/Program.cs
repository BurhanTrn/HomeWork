using System.Runtime.CompilerServices;

namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        // Soru3: Kullanıcıdan alınan bir karakterin sesli harf olup olmadığını kontrol eden bir program yazın. (Veya(`||`) operatörünü araştırınız.)



        System.Console.Write("Lütfen Bir Harf Giriniz: ");
        string metin = Console.ReadLine();

        if (char.TryParse(metin, out char yeniMetin))
        {
            if (yeniMetin)
            {

            }
        }

       


    }
}
