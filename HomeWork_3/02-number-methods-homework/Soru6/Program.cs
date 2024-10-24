namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Lütfen Bir Sayı Giriniz(Derece Cininsden): ");
        string acıDeger = Console.ReadLine();

        if (double.TryParse(acıDeger, out double newDeger))
        {
            double newDeger1 = newDeger * (Math.PI / 180);

            double resultDeger = Math.Sin(newDeger1);

            System.Console.Write($"Girdiğiniz Derece: {newDeger} Trigonometrik Sinüs değeri {resultDeger}");

        }
        else
        {
            System.Console.WriteLine("Lütfen Geçerli Bir Sayı(Derece) Giriniz: ");
        }
    }
}
