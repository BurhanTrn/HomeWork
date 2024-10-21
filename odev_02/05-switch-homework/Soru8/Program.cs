using System.Collections;

namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        // Soru8: Kullanıcıdan alınan bir sayıya göre(0 - 6 arası) bir geometrik şeklin adını yazdıran bir program yazın(0: Nokta, 1: Çizgi, 2: Açı, 3: Üçgen, 4: Kare, 5: Beşgen, 6: Altıgen).

        System.Console.Write("Lütfen 0-6 Arası Bir Sayı Giriniz: ");
        byte ilkdeger;
        if (byte.TryParse(Console.ReadLine(), out ilkdeger))
        {
            switch (ilkdeger)
            {
                case 0:
                    System.Console.WriteLine("Nokta");
                    break;

                case 1:
                    System.Console.WriteLine("Çizgi");
                    break;

                case 2:
                    System.Console.WriteLine("Açı");
                    break;

                case 3:
                    System.Console.WriteLine("Üçgen");
                    break;

                case 4:
                    System.Console.WriteLine("Kare");
                    break;

                case 5:
                    System.Console.WriteLine("Beşgen");
                    break;
                case 6:
                    System.Console.WriteLine("Altıgen");
                    break;
                default:
                    System.Console.WriteLine("Lütfen 0-6 Arası Bir Sayı Giriniz!!! ");
                    break;
            }


        }
        else
        {
            System.Console.WriteLine("Lütfen Bir Sayı Giriniz!!! ");
        }





    }
}
