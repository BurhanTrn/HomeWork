namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        //    Soru10: Kullanıcıdan alınan bir ondalıklı sayıyı, yine kullanıcıdan alınan ondalık basamak sayısına göre yuvarlayan bir program yazın.

        System.Console.Write("Lütfen ondalıklı bir sayı girin: ");
        string deger = Console.ReadLine();

        System.Console.Write("Lütfen ondalık basamak sayısını giriniz: ");
        string deger1 = Console.ReadLine();

        if (double.TryParse(deger, out double newDeger) && int.TryParse(deger1, out int newDeger1))
        {
            double deger2 = Math.Round(newDeger, newDeger1);

            Console.WriteLine(deger2);
        }

        else
        {
            System.Console.WriteLine("Hatalı Giriş Yaptınız!! ");
        }




    }
}
