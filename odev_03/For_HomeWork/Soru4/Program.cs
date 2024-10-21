namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        //        Soru4: Kullanıcıdan bir pozitif tam sayı alın. Bu sayı kadar satırda, her satırda bir önceki satırdan bir fazla olacak şekilde yıldız(*) karakteri ile bir desen çizin.Örneğin, kullanıcı 5 girdiğinde, desen şu şekilde olmalıdır:





        string resultMessage = "";

        try
        {
            System.Console.Write("Lütfen Pozitif Bir Tam Sayı Giriniz: ");
            int number = int.Parse(Console.ReadLine());



            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write("*");



                }
                System.Console.WriteLine();
            }


        }
        catch (OverflowException)
        {
            resultMessage = $"Lütfen {int.MinValue} ile {int.MaxValue} arasında bir değer giriniz!!! ";


            throw;
        }

        catch (FormatException)
        {
            resultMessage = "Geçerli bir değer giriniz!!!";
        }

        finally
        {
            System.Console.WriteLine(resultMessage);
        }










    }
}
