namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        // Soru3: Kullanıcıdan sürekli pozitif tam sayılar alın. Kullanıcı negatif bir sayı girdiğinde, program sona erer ve bu sayılardan her birinin karesini ekrana yazdırır. Örneğin, 4, 5, -1 girildiğinde, program 16 ve 25'i gösterir, ardından sonlanır.

        int sonuc = 0;
        int input = 0;

        do
        {

            System.Console.Write("Pozitif bir tam sayı giriniz: ");
            input = int.Parse(Console.ReadLine());

            if (input > 0)
            {
                sonuc = input * input;
                System.Console.WriteLine($"Girdiğiniz {input} Sayısının karesi {sonuc}");

            }

            else
            {
                System.Console.WriteLine("Geçersiz bir sayı girdiniz. Program Sona Ermiştir!!!");
            }







        } while (input > 0);









    }
}
