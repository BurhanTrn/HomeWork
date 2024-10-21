namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        //   Soru5: Kullanıcıdan alınan bir metinde, yine kullanıcıdan alınan başka bir metni arayan ve varsa ilk bulunduğu indeksi yazdıran bir program yazın.


        System.Console.Write("Lütfen Bir Cümle Giriniz: ");
        string metin = Console.ReadLine();

        System.Console.Write("İndex numarasını öğrenmek istediğiniz kelimeyi yazınız: ");
        string newMetin = Console.ReadLine();

        string metinLower = metin.ToLower();
        String newMetinLower = newMetin.ToLower();

        if (metinLower.Contains(newMetinLower))
        {
            int index = metinLower.IndexOf(newMetinLower);
            System.Console.WriteLine(index);
        }
        else
        {
            System.Console.WriteLine("Aradığınız kelime bulunamamıştır! ");
        }
    }
}

