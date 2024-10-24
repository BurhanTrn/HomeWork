namespace HomeWork13;

class Program
{
    static void Main(string[] args)
    {
        #region Soru 13:

        // `long` tipinde bir değişken oluşturun ve içine çok büyük bir sayı atayın, örneğin 500000000000 gibi.Bu değeri `int` tipine dönüştürmeye çalışın.Sonucu ekrana yazdırın ve ne olduğunu açıklayın.

        #endregion

        long deger = 152304532112;
        int newDeger = (int)deger;
        System.Console.WriteLine(newDeger);

        

        #region Açıklama: 
        // long veri tipinden int veri tipine dönüşüm yaptığımız sayı , int veri türünün alabileceği değer aralığının dışındaysa yani taşma yaşanıyorsa int veri türünün alabileceği negatif ve pozitif değerler toplanır ve dönüştürülen sayıyla bölünür. Kalan değer aralığı içerisindeyse sonuç ekrana yazılır. 


        #endregion

    }
}
