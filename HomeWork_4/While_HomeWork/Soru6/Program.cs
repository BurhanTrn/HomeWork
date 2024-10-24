namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Lütfen Bir Metin Giriniz: ");
        string alınanMetin = Console.ReadLine();
        string resultMessage = "";

        int i = alınanMetin.Length - 1;

        while (i >= 0)

        {
            resultMessage += alınanMetin[i];
            i--;
        }
        System.Console.WriteLine($"Metnin Ters Çevrilmiş Hali=> {resultMessage}");


    }
}
