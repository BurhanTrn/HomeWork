using System.Runtime.InteropServices;

namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        //   Soru6: Kullanıcıdan 10'dan büyük bir pozitif tam sayı girmesini isteyin. 1’den bu sayıya kadar olan tüm sayıların karelerini hesaplayın ve her sayının karesini ekrana yazdırın. Örneğin, kullanıcı 12 girdiğinde, 1^2, 2^2, …, 12^2 sonuçlarını ekranda görmelidir.

        try
        {
            System.Console.Write("Lütfen 10 sayısından büyük Pozitif bir tam sayı giriniz: ");
            int alınanVeri = int.Parse(Console.ReadLine());
            int number = 0;

            if (alınanVeri < 10)
            {
                System.Console.WriteLine("Lütfen 10'dan büyük bir sayı Giriniz!!");
            }
            else
            {
                for (int i = 1; i <= alınanVeri; i++)
                {
                    number = i * i;
                    System.Console.WriteLine(($"{i}^2={number}"));
                }

            }
        }
        catch (FormatException)
        {
            System.Console.WriteLine("Lütfen Bir Sayı Giriniz!!!");

        }





    }
}
