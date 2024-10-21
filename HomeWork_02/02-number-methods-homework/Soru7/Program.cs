namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Lütfen Bir Sayı Giriniz(Derece Cinsinden): ");
        string acıDeger = Console.ReadLine();

        if (double.TryParse(acıDeger, out double newDeger))
        {
            double newDeger1 = newDeger * (Math.PI / 180);

            System.Console.Write($"Girdiğiniz Derece: {newDeger} Radyan Cinsinden Değeri {newDeger1} rad");

        }
        else
        {
            System.Console.WriteLine("Lütfen Geçerli Bir Sayı(Derece) Giriniz: ");
        }
    }
}
