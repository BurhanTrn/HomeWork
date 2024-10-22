namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("İlk tarihi 'dd/MM/yyyy' formatında girin: ");
        string tarih1Girdisi = Console.ReadLine();

        Console.Write("İkinci tarihi 'dd/MM/yyyy' formatında girin: ");
        string tarih2Girdisi = Console.ReadLine();


        DateTime tarih1 = DateTime.ParseExact(tarih1Girdisi, "dd/MM/yyyy", null);
        DateTime tarih2 = DateTime.ParseExact(tarih2Girdisi, "dd/MM/yyyy", null);


        if (tarih1 < tarih2)
        {
            Console.WriteLine("İlk tarih, ikinci tarihten önce.");
        }
        else if (tarih1 > tarih2)
        {
            Console.WriteLine("İlk tarih, ikinci tarihten sonra.");
        }
        else
        {
            Console.WriteLine("Her iki tarih aynıdır.");
        }
    }
}
