namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        //     Soru9: Kullanıcıdan alınan iki sayı ve bir işlem(+, -, *, /) için basit bir hesap makinesi yapın.
        // 

        System.Console.Write("Lütfen Sayı Giriniz: ");
        double sayi1 = double.Parse(Console.ReadLine());


        System.Console.Write("Lütfen Sayı Giriniz: ");
        double sayi2 = double.Parse(Console.ReadLine());

        System.Console.Write("Lütfen Yapmak İstediğiniz İşlemi(+,-,%,*) Giriniz: ");
        char karakter = char.Parse(Console.ReadLine());


        string resultMessage = " ";

        if (karakter == '+')
        {
            double sonSayi = sayi1 + sayi2;
            resultMessage = ($"Girdiğiniz sayıların toplama işlemi Sonucu: {sonSayi}");
        }

        else if (karakter == '-')
        {
            double sonSayi = sayi1 - sayi2;
            resultMessage = ($"Girdiğiniz sayıların Çıkarma işlemi Sonucu: {sonSayi}");

        }

        else if (karakter == '/')
        {
            double sonSayi = sayi1 / sayi2;
            resultMessage = ($"Girdiğiniz sayıların bölme işlemi Sonucu: {sonSayi}");
        }
        else if (karakter == '*')
        {
            double sonSayi = sayi1 * sayi2;
            resultMessage = ($"Girdiğiniz sayıların çarpma işlemi Sonucu: {sonSayi}");
        }



        else
        {
            System.Console.WriteLine("Lütfen Geçerli Bir Sayı veya Karakter girin!!!");
        }
        System.Console.WriteLine(resultMessage);



    }
}
