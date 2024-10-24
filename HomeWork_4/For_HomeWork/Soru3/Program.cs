namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        //    Soru3: Kullanıcıdan bir pozitif tam sayı alın. Bu sayının tüm tam bölenlerini bulan ve ekrana yazdıran bir program yazın. Bir tam bölen, bir sayıyı tam bölen herhangi bir tam sayıdır. Örneğin, 12 sayısı için tam bölenler 1, 2, 3, 4, 6 ve 12'dir.
        // 
        System.Console.Write("Lütfen Pozitif Bir Tam Sayı Giriniz: ");
        string veri = Console.ReadLine();



        if (int.TryParse(veri, out int number) && number > 0)
        {

            System.Console.WriteLine($"{number} sayısının tam bölenleri: ");


            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {

                    System.Console.WriteLine(i);
                }
            }
        }
        else
        {
            System.Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz!!!");
        }
    }
}
