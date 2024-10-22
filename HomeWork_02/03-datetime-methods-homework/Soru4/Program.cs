namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen ilk tarihi girin (yyyy-MM-dd formatında): ");
        string tarih1Input = Console.ReadLine();

        Console.Write("Lütfen ikinci tarihi girin (yyyy-MM-dd formatında): ");
        string tarih2Input = Console.ReadLine();

       
        if (DateTime.TryParse(tarih1Input, out DateTime tarih1) &&
            DateTime.TryParse(tarih2Input, out DateTime tarih2))
        {
            TimeSpan fark = tarih2 - tarih1;
            int gunFarki = Math.Abs(fark.Days); 

           
            Console.WriteLine("İki tarih arasındaki gün farkı: " + gunFarki + " gün");
        }
        else
        {
            Console.WriteLine("Geçersiz tarih formatı girdiniz. Lütfen yyyy-MM-dd formatında tarih girin.");
        }
    }
}

