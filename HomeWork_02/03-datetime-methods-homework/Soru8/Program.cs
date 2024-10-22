namespace Soru8;

class Program
{
    static void Main(string[] args)
    {

        DateTime simdi = DateTime.Now;


        string ayAdi = simdi.ToString("MMMM");


        Console.WriteLine("Şu anki ay: " + ayAdi);
    }
}
