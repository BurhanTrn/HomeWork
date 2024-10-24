namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        //    Soru5: 1’den 100’e kadar olan tüm asal sayıları bulan ve ekrana yazdıran bir program yazın.Asal sayılar yalnızca 1 ve kendisi ile bölünebilen pozitif tam sayılardır.Örneğin, 2, 3, 5, 7 gibi sayılar asal sayıdır.

        for (int i = 2; i <= 100; i++)
        {
            bool isPrime = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }

            }
            if (isPrime)
            {
                System.Console.WriteLine(i);
            }
        }





    }
}
