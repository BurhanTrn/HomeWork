namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci Sayıyı Giriniz: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());


        Console.Write("İkinci Sayıyı Giriniz: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());



        System.Console.WriteLine("Yapmak İstediğiniz İşlemi Giriniz: (+,-,*,/) ");
        char islem = Console.ReadLine()[0];

        double sonuc;
        switch (islem)
        {
            case '+':
                sonuc = sayi1 + sayi2;
                System.Console.WriteLine(sonuc);
                break;

            case '-':
                sonuc = sayi1 - sayi2;
                System.Console.WriteLine(sonuc);
                break;

            case '*':
                sonuc = sayi1 * sayi2;
                System.Console.WriteLine(sonuc);
                break;

            case '/':
                if (sayi1 != 0 && sayi2 != 0)

                {
                    sonuc = sayi1 / sayi2;
                    System.Console.WriteLine(sonuc);
                }
                else
                {
                    System.Console.WriteLine("Bölme işleminde 0 değeri geçersizdir!!! ");
                }
                break;

            default:

                System.Console.WriteLine("Yanlış İşlem Yaptınız!");
                break;

        }



    }
}
