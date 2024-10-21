namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        //    Soru8: Kullanıcıdan alınan bir sayının logaritmasını (doğal logaritma) hesaplayan bir program yazın.

        System.Console.Write("Logaritmasını Öğrenmek İStediğiniz Sayıyı Giriniz: ");
        string deger = Console.ReadLine();

        if (double.TryParse(deger, out double newDeger))

        {
            double newDeger1 = Math.Log10(newDeger);

            System.Console.Write($"Girdiğiniz {newDeger} sayısının Onluk Logaritma Değeri: {newDeger1}");
        }
        else
        {
            System.Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz!!!");
        }


    }
}
