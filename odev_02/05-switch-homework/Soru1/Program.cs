namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("1-7 Arasında Bir Sayı Giriniz: ");
        int günsayisi;

        if (int.TryParse(Console.ReadLine(), out günsayisi))
        {
            switch (günsayisi)
            {
                case 1:
                    System.Console.WriteLine("Pazartesi");
                    break;


                case 2:
                    System.Console.WriteLine("Salı");
                    break;


                case 3:
                    System.Console.WriteLine("Çarşamba");
                    break;


                case 4:
                    System.Console.WriteLine("Perşembe");
                    break;


                case 5:
                    System.Console.WriteLine("Cuma");
                    break;


                case 6:
                    System.Console.WriteLine("Cumartesi");
                    break;


                case 7:
                    System.Console.WriteLine("Pazar");
                    break;
                default:
                    System.Console.WriteLine("1-7 Arasında bir sayı giriniz!");
                    break;


            }
        }
        else
        {
            System.Console.WriteLine("Lütfen Bir Sayı Giriniz!");
        }
    }
}
