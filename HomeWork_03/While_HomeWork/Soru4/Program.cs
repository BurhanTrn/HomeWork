namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        // Soru4: Kullanıcıdan bir sayı alın ve bu sayının rakamlarının toplamını while döngüsü ile hesaplayın. Sonucu ekrana yazdırın. Örneğin, 245 sayısı girildiğinde, program 2+4+5 işlemini yaparak sonucu ekranda göstermelidir.

        System.Console.Write("Lütfen Bir Sayı Giriniz: ");
        string alınanVeri = Console.ReadLine();

        int sonuc = 0;
        int index = 0;

        while (index < alınanVeri.Length)
        {
            char karakter = alınanVeri[index];
            int number = karakter - '0';
            sonuc += number;
            index++;

        }

        System.Console.WriteLine(sonuc);



    }
}
