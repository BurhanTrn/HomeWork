namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        //    Soru10: Kullanıcıdan alınan bir sayının asal olup olmadığını kontrol eden bir program yazın.
        bool isPrime = true;
        System.Console.Write("Lütfen Bir Sayı Giriniz: ");
        int deger = int.Parse(Console.ReadLine());

        if (deger <= 1)
        {
            isPrime = false;
        }

        else
        {



            for (int i = 2; i <= deger - 1; i++)
            {
                if (deger % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

        }

        System.Console.WriteLine(isPrime ? "Asal" : "Asal Değil");




    }
}
