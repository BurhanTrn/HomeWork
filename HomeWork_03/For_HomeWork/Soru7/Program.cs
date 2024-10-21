namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        // Soru7: Kullanıcıdan bir pozitif tam sayı alın. Bu sayıya kadar olan çift sayıların toplamını hesaplayın ve sonucu ekrana yazdırın. Örneğin, kullanıcı 10 girerse, program 2 + 4 + 6 + 8 + 10 toplamını hesaplayıp sonucu göstermelidir.

        try
        {
            System.Console.Write("Lütfen Pozitif Bir Tam Sayı Giriniz: ");
            int input = int.Parse(Console.ReadLine());
            int number = 0;

            if (input < 0)
            {
                System.Console.WriteLine("Lütfen 0'dan büyük bir sayı giriniz!!!");
            }

            else
            {
                for (int i = 2; i <= input; i += 2)
                {
                    number += i;
                }

                System.Console.WriteLine($"Girilen Sayı={input}  Girilen sayının çif sayıları toplamı= {number}");
            }
        }

        catch (FormatException)
        {
            System.Console.WriteLine("Lütfen Bir Sayı Giriniz!!!");

        }
    }
}
