namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Matematiksel İfadelerden Birini Giriniz: ---> (+, -, *, /, %) :  ");
        char deger = (Console.ReadLine()[0]);


        {
            switch (deger)
            {
                case '+':
                    System.Console.WriteLine("Toplama ");
                    break;

                case '-':
                    System.Console.WriteLine("Çıkarma ");
                    break;

                case '*':
                    System.Console.WriteLine("Çarpma ");
                    break;
                case '/':
                    System.Console.WriteLine("Bölme ");
                    break;
                case '%':
                    System.Console.WriteLine("Yüzde İşareti(Bölü Yüz İşareti) ");
                    break;
                default:
                    System.Console.WriteLine("Lütfen İstenilen Bir Matematiksel İfade Giriniz!!! ");
                    break;

            }
        }






    }
}
