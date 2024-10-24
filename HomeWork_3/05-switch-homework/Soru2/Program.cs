namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        // Soru2. Kullanıcıdan alınan bir sayıya göre(1 - 12 arası) ayın adını yazdıran bir program yazın.


        System.Console.Write("Lütfen 1-12 Arasında Bir Sayı Giriniz: ");

        int aySayisi;

        if (int.TryParse(Console.ReadLine(), out aySayisi))

        {

            switch (aySayisi)

            {
                case 1:
                    System.Console.WriteLine("Ocak");
                    break;





                case 2:
                    System.Console.WriteLine("Şubat");
                    break;


                case 3:
                    System.Console.WriteLine("Mart");
                    break;


                case 4:
                    System.Console.WriteLine("Nisan");
                    break;


                case 5:
                    System.Console.WriteLine("Mayıs");
                    break;



                case 6:
                    System.Console.WriteLine("Haziran");
                    break;


                case 7:
                    System.Console.WriteLine("Temmuz");
                    break;


                case 8:
                    System.Console.WriteLine("Ağustos");
                    break;


                case 9:
                    System.Console.WriteLine("Eylül");
                    break;


                case 10:
                    System.Console.WriteLine("Ekim");
                    break;


                case 11:
                    System.Console.WriteLine("Kasım");
                    break;

                case 12:
                    System.Console.WriteLine("Aralık");
                    break;
                default:
                    System.Console.WriteLine("Lütfen 1-12 Arasında Bir Sayı Giriniz!");
                    break;
            }

        }
        else

        {
            System.Console.WriteLine("Lütfen Bir Sayı Giriniz!");
        }
    }
}
