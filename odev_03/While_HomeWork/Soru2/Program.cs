namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        // Soru2: Kullanıcıdan bir metin alın. Bu metindeki tüm harfleri büyük harfe çeviren bir program yazın. Sadece harf karakterleri büyük harfe çevrilmeli, diğer karakterler(noktalama işaretleri vb.) olduğu gibi kalmalıdır.Örneğin, "Merhaba Dünya!" metni "MERHABA DÜNYA!" olarak ekrana yazdırılmalıdır.
        string veri = "";
        string metin = "";

        do
        {
            System.Console.Write("Lütfen Bir Metin Giriniz: ");
            veri = Console.ReadLine();
            metin = veri.ToUpper();



        } while (false);

        System.Console.WriteLine($"Girdiğiniz metnin-->{veri} karakter boyutu değiştirilmiş hali--> {metin} ");



    }
}
