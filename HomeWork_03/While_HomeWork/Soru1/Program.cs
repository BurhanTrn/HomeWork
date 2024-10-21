namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        // Soru1: Kullanıcıdan pozitif tam sayılar girmesini isteyin. Kullanıcı sıfır girdiğinde, program sona erer ve girilen tüm sayıların toplamını ekrana yazdırır. Her sayının toplanmasından sonra kullanıcıya yeni bir sayı girmesi istenir. Program sadece sıfır girildiğinde sona ermelidir.

        int deger = 1;
        int sonuc = 0;


        do
        {
            System.Console.Write("Lütfen Pozitif Bir Sayı Giriniz: ");
            deger = int.Parse(Console.ReadLine());

            sonuc += deger;




        } while (deger != 0);

        System.Console.WriteLine($"Girdiğiniz Sayılar Toplamı: {sonuc} ");
    }
}
