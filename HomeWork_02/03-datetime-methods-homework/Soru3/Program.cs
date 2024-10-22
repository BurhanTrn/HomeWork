namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        {
            Console.Write("Lütfen bir tarih girin (yyyy-MM-dd formatında): ");
            string tarihInput = Console.ReadLine();


            if (DateTime.TryParse(tarihInput, out DateTime tarih))
            {
                Console.Write("Eklenecek gün sayısını girin: ");
                if (int.TryParse(Console.ReadLine(), out int gunSayisi))
                {

                    DateTime yeniTarih = tarih.AddDays(gunSayisi);


                    Console.WriteLine("Yeni tarih: " + yeniTarih.ToString("yyyy-MM-dd"));
                }
                else
                {
                    Console.WriteLine("Geçersiz gün sayısı girdiniz.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz bir tarih formatı girdiniz. Lütfen yyyy-MM-dd formatında bir tarih girin.");
            }
        }
    }
}

