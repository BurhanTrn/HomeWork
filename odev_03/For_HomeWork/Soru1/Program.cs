namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        // Soru1: Kullanıcıdan pozitif bir tam sayı girmesini isteyin. 1'den bu sayıya kadar olan tüm tam sayıların toplamını bulan ve sonucu ekrana yazdıran bir program yazın. Örneğin, kullanıcı 5 girdiğinde, program 1+2+3+4+5 toplamını hesaplayıp sonucu göstermelidir.

        int number = default;
        int resultNumber = default;
        string resultMessage = default;

        try
        {
            System.Console.Write("Lütfen Pozitif Bir Tam Sayı Giriniz: ");
            number = int.Parse(Console.ReadLine());



            for (int i = 0; i <= number; i++)
            {

                resultNumber += i;

            }

            System.Console.WriteLine(resultNumber);

        }
        catch (FormatException)
        {

            resultMessage = "Lütfen Geçerli Bir değer giriniz!!";


        }

        catch (OverflowException)
        {

            resultMessage = $"Lütfen {int.MinValue}-{int.MaxValue} arasında bir değer giriniz!!!";
        }

        finally
        {
            Console.WriteLine(resultMessage);

        }









    }
}
