namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        // Soru2:Kullanıcıdan bir pozitif tam sayı isteyin. Bu sayı ile 1'den bu sayıya kadar olan sayıların küplerini hesaplayın. Her bir sayının küpünü ayrı satırlarda ekrana yazdırın. Örneğin, kullanıcı 3 girdiğinde, 1^3, 2^3 ve 3^3 sonuçlarını görmelidir. Not: `Pow` kullanmayın.

        System.Console.Write("Lütfen Pozitif Bir Tam Sayı Giriniz: ");
        string alınanVeri = Console.ReadLine();
        int resultNumber = 0;


        if (int.TryParse(alınanVeri, out int input) && input > 0)
        {
            for (int i = 1; i <= input; i++)
            {
                resultNumber = i * i * i;
                System.Console.WriteLine($"{i} Sayısının küpü: {resultNumber}");
            }

        }

        else
        {
            System.Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz!!");
        }



    }
}
