namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir tarih girin (yyyy-MM-dd formatında): ");
        string tarihInput = Console.ReadLine();


        if (DateTime.TryParse(tarihInput, out DateTime tarih))
        {

            int gunSayisi = tarih.DayOfYear;


            Console.WriteLine("Girdiğiniz tarih: " + tarih.ToString("yyyy-MM-dd"));
            Console.WriteLine("Bu tarihin yılın kaçıncı günü: " + gunSayisi);
        }
        else
        {
            Console.WriteLine("Geçersiz bir tarih formatı girdiniz. Lütfen yyyy-MM-dd formatında bir tarih girin.");
        }
    }
}

