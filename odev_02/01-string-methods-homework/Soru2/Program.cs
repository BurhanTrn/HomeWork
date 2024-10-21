namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        //    Soru2 : Kullanıcıdan alınan bir metni tüm harfleri büyük olacak şekilde ve tüm harfleri küçük olacak şekilde alt alta tek bir Console.Write ile ekrana yazdıran bir program yazın.
        // 

        Console.Write("Bir metin giriniz: ");
        string metin = Console.ReadLine();

        string mesaj = metin.ToLower();
        string mesaj1 = metin.ToUpper();

        Console.Write($"{mesaj}\n{mesaj1}");



















    }
}
