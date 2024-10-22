namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        static void Main()
        {
            Console.Write("Tarihi 'dd/MM/yyyy' formatında girin: ");
            string tarihGirdisi = Console.ReadLine();

            DateTime tarih = DateTime.ParseExact(tarihGirdisi, "dd/MM/yyyy", null);

            Console.WriteLine("Girdiğiniz tarih: " + tarih.ToString("dd/MM/yyyy"));
        }
    }
}
