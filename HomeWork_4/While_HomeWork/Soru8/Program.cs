using System.Globalization;

namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        // Soru8: Kullanıcıdan pozitif tam sayılar girmesini isteyin. Kullanıcı 100’den büyük bir sayı girdiğinde program sona erer. Kaç tane sayı girildiğini, girilen sayıların toplamını ve girilen sayıların ortalamasını ekrana yazdırın.


        int toplam=0;
        int ortalama=0;
        int number=0;
        
        

        do
        {
            System.Console.WriteLine("Pozitif Sayı Giriniz: ");
            number = int.Parse(Console.ReadLine());

            toplam += number;



        } while (number!=101);

        
        System.Console.WriteLine(toplam);












    }
}
