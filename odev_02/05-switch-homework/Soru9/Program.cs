namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        //   Soru9: Kullanıcıdan alınan bir sayıya göre(1 - 5 arası) Türkçe sayı sıfatını yazdıran bir program yazın(1: Birinci, 2: İkinci, vb.).


        System.Console.Write("Lütfen 1-5 Arası Bir Sayı Giriniz: ");
        byte ilkdeger;
        if (byte.TryParse(Console.ReadLine(), out ilkdeger))
        {
            switch (ilkdeger)
            {
              

                case 1:
                    System.Console.WriteLine("Birinci");
                    break;

                case 2:
                    System.Console.WriteLine("İkinci");
                    break;

                case 3:
                    System.Console.WriteLine("Üçüncü");
                    break;

                case 4:
                    System.Console.WriteLine("Dördüncü");
                    break;

                case 5:
                    System.Console.WriteLine("Beşinci");
                    break;
                
                default:
                    System.Console.WriteLine("Lütfen 1-5 Arası Bir Sayı Giriniz!!! ");
                    break;
            }


        }
        else
        {
            System.Console.WriteLine("Lütfen Bir Sayı Giriniz!!! ");
        }


    }
}
