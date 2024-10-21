namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        // Soru9: Kullanıcıdan bir pozitif tam sayı alın. Bu sayının asal olup olmadığını kontrol eden bir program yazın. Eğer sayı asal ise ekrana "Asal Sayıdır" değilse "Asal Sayı Değildir" yazdırın.
        bool isPrime = true;
        System.Console.Write("Lütfen Pozitif Bir Tam Sayı Giriniz: ");
        int number = int.Parse(Console.ReadLine());

        string resultMessage;

        for (int i = 2; i <= number - 1; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                System.Console.WriteLine("Girilen Sayı Asal Değildir!!");
                break;
            }
        }

        if (isPrime)
        {
            System.Console.WriteLine("Girilen Sayı Asal Bir Sayıdır!!!");
        }

       


        

       





    }
}
