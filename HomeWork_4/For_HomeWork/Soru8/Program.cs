namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        // Soru8: Kullanıcıdan bir pozitif tam sayı alın. Bu sayıdan başlayarak geriye doğru sayarak 1’e kadar olan tüm sayıların karesini hesaplayın ve her sayının karesini ayrı satırlarda ekrana yazdırın.


        System.Console.Write("Lütfen Bir Sayı Giriniz: ");
        int alınanveri = int.Parse(Console.ReadLine());
        int number = 0;

        for (int i = alınanveri; i > 1; i--)
        {
            number = i * i;
            System.Console.WriteLine($"{i}^2= {number}");
        }




    }
}
