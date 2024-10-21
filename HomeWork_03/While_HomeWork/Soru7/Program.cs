namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        // Soru7: Kullanıcıdan bir pozitif tam sayı ve bir üst sınır değeri alın. İlk sayı üst sınırdan küçük olduğu sürece, sayıyı iki katına çıkararak yeniden kontrol edin. Bu işlem sayı üst sınırı geçene kadar devam etmelidir. Sonucu her aşamada ekrana yazdırın.

        System.Console.Write("Lütfen Bir Sayı Giriniz: ");
        int alınanSayi = int.Parse(Console.ReadLine());

        System.Console.Write("Üst Sınır Giriniz: ");
        int alınanUst = int.Parse(Console.ReadLine());

        while (alınanSayi < alınanUst)
        {
            System.Console.WriteLine($"Mevcut sayı" + alınanSayi);
            alınanSayi *= 2;
        }

        System.Console.WriteLine("Sonuç: " + alınanSayi);














    }
}
