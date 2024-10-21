namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        // Soru4: Kullanıcıdan alınan bir cümlenin başındaki ve sonundaki boşlukları kaldıran bir program yazın. (`Trim` metotlarını araştırınız.)


        System.Console.Write("Başında ve Sonunda boşluk olacak şekilde bir cümle yazınız: ");
        string alınanVeri = Console.ReadLine();

        string trim1 = alınanVeri.TrimStart();
        string trim2 = alınanVeri.TrimEnd();

        System.Console.WriteLine(trim1, trim2);

        System.Console.WriteLine(alınanVeri);

        







    }
}
