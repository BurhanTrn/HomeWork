using System.Diagnostics;

namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        //    Soru5: Kullanıcıdan alınan bir sayıya göre(1 - 4 arası) mevsim adını yazdıran bir program yazın.

        System.Console.Write("1-4 Arası Bir Rakam Giriniz: ");
        byte kullanıcıDeger;
        if (byte.TryParse(Console.ReadLine(), out kullanıcıDeger))
        {
            switch (kullanıcıDeger)
            {
                case 1:
                    System.Console.WriteLine("İlkbahar");
                    break;

                case 2:
                    System.Console.WriteLine("Yaz");
                    break;

                case 3:
                    System.Console.WriteLine("Sonbahar");
                    break;

                case 4:
                    System.Console.WriteLine("Kış");
                    break;

                default:
                    System.Console.WriteLine("Lütfen Sayı 1-4 Arasında bir rakam giriniz!!! ");
                    break;

            }

        }
        else
        {
            System.Console.WriteLine("Lütfen Bir Rakam Giriniz!! ");
        }



    }
}
