namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        static void Main()
        {
            Console.Write("Saati 12 saat formatında girin (örneğin, 02:30 PM): ");
            string saatGirdisi = Console.ReadLine();

            try
            {

                DateTime saat24 = DateTime.Parse(saatGirdisi);
                Console.WriteLine("24 saat formatı: " + saat24.ToString("HH:mm"));
            }
            catch
            {
                Console.WriteLine("Geçersiz saat formatı. Lütfen 'hh:mm tt' formatında bir saat girin.");
            }
        }
    }
}
