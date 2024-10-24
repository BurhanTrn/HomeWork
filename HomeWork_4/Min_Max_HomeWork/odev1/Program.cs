namespace odev1;

class Program
{
    static void Main(string[] args)
    {
        //         //### Min Max

        // #### Aşağıdaki programı for ve while ile ayrı ayrı yazınız.

        //         Kullanıcının gireceği 5 sayı arasındaki en büyük ve en küçük değeri bulup ekrana yazdıran programı yazınız.Örneğin kullanıcı sırasıyla 90,4,55,3,66 sayılarını girmişse program

        //         En Büyük = 90
        // En Küçük = 3

        // şeklinde sonuç vermelidir.


        // For Döngüsü ile;
        //--------------------------------------------------------------
        // int enBuyuk = int.MinValue;
        // int enKucuk = int.MaxValue;

        // for (int i = 0; i < 5; i++)
        // {
        //     Console.Write($"{i + 1}. sayıyı giriniz: ");
        //     int sayi = Convert.ToInt32(Console.ReadLine());

        //     if (sayi > enBuyuk)
        //     {
        //         enBuyuk = sayi;
        //     }
        //     if (sayi < enKucuk)
        //     {
        //         enKucuk = sayi;
        //     }
        // }

        // Console.WriteLine($"En Büyük = {enBuyuk}");
        // Console.WriteLine($"En Küçük = {enKucuk}");


        // While Döngüsü ile;
        //----------------------------------------------------------------------------

        int i = 0;
        int enBuyuk = int.MinValue;
        int enKucuk = int.MaxValue;
        int sayac = 1;

        while (i < 5)
        {
            System.Console.WriteLine($"Lütfen {sayac}.Sayıyı Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            i++;
            sayac++;
            if (sayi > enBuyuk)
            {
                enBuyuk = sayi;
            }

            if (sayi < enKucuk)
            {
                enKucuk = sayi;
            }
        }
        System.Console.WriteLine($"En Büyük = {enBuyuk}");
        System.Console.WriteLine($"En Küçük = {enKucuk}");











    }
}
