namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        //    Soru1: Kullanıcıdan alınan bir sayının pozitif, negatif veya sıfır olduğunu kontrol eden bir program yazın.
        string resultMessage = "";
        System.Console.Write("Lütfen Bir Sayı Giriniz: ");
        string deger = Console.ReadLine();

        if (int.TryParse(deger, out int newDeger))
        {

            if (newDeger > 0)
            {
                resultMessage = "Girdiğiniz sayı pozitif bir sayıdır. ";
            }
            else if (newDeger < 0)
            {
                resultMessage = "Girdiğiniz sayı negatif bir sayıdır";
            }

            else if (newDeger == 0)
            {
                resultMessage = "Girdiğiniz sayı 0'dır.. ";
            }

        }
        else
        {
            resultMessage = "Lütfen bir sayı giriniz!!! ";
        }


        System.Console.WriteLine(resultMessage);

    }
}

