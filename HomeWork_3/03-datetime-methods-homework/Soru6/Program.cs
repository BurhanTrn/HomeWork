namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir yıl girin: ");

      
        if (int.TryParse(Console.ReadLine(), out int yil))
        {
            
            bool artikYil = (yil % 4 == 0 && yil % 100 != 0) || (yil % 400 == 0);

            if (artikYil)
            {
                Console.WriteLine($"{yil} bir artık yıldır.");
            }
            else
            {
                Console.WriteLine($"{yil} bir artık yıl değildir.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz bir yıl girdiniz. Lütfen geçerli bir tam sayı girin.");
        }
    }
}
