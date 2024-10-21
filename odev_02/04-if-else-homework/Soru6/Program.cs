using System.Linq.Expressions;

namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        // Soru6: Kullanıcıdan alınan bir notun aşağıdaki tabloya göre harf karşılığını veren bir program yazın.

        string resultMessage = " ";

        System.Console.Write("Lütfen Aldığınız Notu Giriniz(0-100):  ");
        string veri = Console.ReadLine();

        if (byte.TryParse(veri, out byte newVeri))



            if (newVeri == 0)
            {
                resultMessage = "Devamsız!!!";
            }

            else if (newVeri < 40)
            {
                resultMessage = "Notunuz: FF  Durumunuz:YS";


            }


            else if (newVeri < 50)
            {
                resultMessage = "Notunuz: FD  Durumunuz:YS";
            }

            else if (newVeri < 55)
            {
                resultMessage = "Notunuz: DD Durumunuz:YE";

            }

            else if (newVeri < 60)
            {
                resultMessage = "Notunuz: DC Durumunuz:YE";
            }

            else if (newVeri < 70)
            {
                resultMessage = "Notunuz: CC Durumunuz:YE";
            }
            else if (newVeri < 80)
            {
                resultMessage = "Notunuz: CB Durumunuz:YE";
            }

            else if (newVeri < 85)
            {
                resultMessage = "Notunuz: BB Durumunuz:YE";
            }

            else if (newVeri < 90)
            {
                resultMessage = "Notunuz: BC Durumunuz:YE";
            }

            else if (newVeri <= 100)
            {
                resultMessage = "Notunuz: AA Durumunuz:YE";
            }

            else
            {
                resultMessage = "Lütfen Geçerli Bir Sayı Giriniz!!";
                System.Console.WriteLine(resultMessage);
            }
        System.Console.WriteLine(resultMessage);








    }
}
