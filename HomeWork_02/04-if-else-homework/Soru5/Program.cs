namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen üç kenar uzunluğunu giriniz:");


        Console.Write("Birinci kenar: ");
        int kenar1 = int.Parse(Console.ReadLine());

        Console.Write("İkinci kenar: ");
        int kenar2 = int.Parse(Console.ReadLine());

        Console.Write("Üçüncü kenar: ");
        int kenar3 = int.Parse(Console.ReadLine());


        if (kenar1 + kenar2 > kenar3 &&
            kenar1 + kenar3 > kenar2 &&
            kenar2 + kenar3 > kenar1)
        {
            Console.WriteLine("Girdiğiniz kenar uzunlukları bir üçgen oluşturur.");
        }
        else
        {
            Console.WriteLine("Girdiğiniz kenar uzunlukları bir üçgen oluşturmaz.");
        }
    }
}
