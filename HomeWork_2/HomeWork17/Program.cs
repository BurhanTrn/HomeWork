namespace HomeWork17;

class Program
{
  static void Main(string[] args)
  {
    #region Soru 17:

    //    `byte`, `short`, `int`, ve `long` tiplerinde değişkenler oluşturun ve her birine aynı sayısal değeri(örneğin 42) atayın.Bu değişkenlerin bellekte kapladıkları alanı `sizeof()` operatörünü kullanarak ekrana yazdırın.`sizeof()` nasıl kullanılır, araştırın.

    #endregion

    byte sayi1 = 42;
    short sayi2 = 42;
    int sayi3 = 42;
    long sayi4 = 42;

    System.Console.WriteLine("Sayı1'in boyutu : " + sizeof(byte) + "Byte");
    System.Console.WriteLine("Sayı2'nin boyutu : " + sizeof(short) + "Byte");
    System.Console.WriteLine("Sayı3'ün boyutu : " + sizeof(int) + "Byte");
    System.Console.WriteLine("Sayı4'ün boyutu : " + sizeof(long) + "Byte");

  }
}
