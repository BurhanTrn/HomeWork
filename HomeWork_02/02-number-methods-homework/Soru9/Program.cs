namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        //    Soru9: Kullanıcıdan alınan iki sayı arasındaki küçük olanı bulan bir program yazın.

        System.Console.Write("İlk Sayıyı Giriniz: ");
        string ilkDeger = Console.ReadLine();


        System.Console.Write("İkinci Sayıyı Giriniz: ");
        string ikinciDeger = Console.ReadLine();

        if (double.TryParse(ilkDeger, out double newDeger) && double.TryParse(ikinciDeger, out double newDeger1))
        

        if (newDeger==newDeger1)

        {
        System.Console.WriteLine("Girdiğiniz Sayılar Birbirine eşittir.");    
        }

        {
            double sonDeger = Math.Min(newDeger, newDeger1);
            System.Console.WriteLine($"Küçük Olan Sayı: {sonDeger}");
        }

    

        else
        {
            System.Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz!!");
        }










    }
}
