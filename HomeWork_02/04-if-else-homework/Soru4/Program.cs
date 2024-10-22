namespace Soru4;

class Program
{
    static void Main(string[] args)
    {

        int alınanVeri = 0;

        System.Console.WriteLine("Lütfen artık yıl olup olmadığını öğrenmek istediğiniz yılı giriniz: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out alınanVeri))
        {
            if (alınanVeri % 4 == 0 && alınanVeri % 100 != 0 || alınanVeri % 400 == 0)
            {
                System.Console.WriteLine($"Girdiğiniz {alınanVeri} yılı artık yıldır.");
            }
            else
            {
                System.Console.WriteLine($"Girdiğiniz {alınanVeri} yılı artık yıl DEĞİLDİR!");
            }
        }
        else
        {
            System.Console.WriteLine("Lütfen Geçerli bir yıl giriniz!!");
        }




    }
}
