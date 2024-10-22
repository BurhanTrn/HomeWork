namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir tarih girin (yyyy-MM-dd formatında): ");
        string tarihInput = Console.ReadLine();


        if (DateTime.TryParse(tarihInput, out DateTime tarih))
        {
            string gun = tarih.DayOfWeek.ToString();

            Console.WriteLine("Girdiğiniz tarih: " + tarih.ToString("yyyy-MM-dd"));
            Console.WriteLine("Bu tarihin haftanın günü: " + gun);
        }
        else
        {
            Console.WriteLine("Geçersiz bir tarih formatı girdiniz. Lütfen yyyy-MM-dd formatında bir tarih girin.");
        }
    }
}

