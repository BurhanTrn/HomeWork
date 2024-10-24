namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        // Soru6 : Kullanıcıdan alınan bir nota göre(A, B, C, D, F) geçme veya kalma durumunu belirleyen bir program yazın.

        System.Console.Write("Lütfen Aldığınız Notu Giriniz: ");
        byte alınanNot;

        if (byte.TryParse(Console.ReadLine(), out alınanNot))
        {
            switch (alınanNot)
            {
                case < 39:
                    if (alınanNot == 0)
                    {
                        System.Console.WriteLine("DS");
                    }
                    else
                    {
                        System.Console.WriteLine("Harf Notu : FF -- YS");
                    }

                    break;

                case < 49:


                    System.Console.WriteLine("Harf Notu : FD -- YS");
                    break;

                case < 54:


                    System.Console.WriteLine("Harf Notu : DD -- YE");
                    break;

                case < 59:


                    System.Console.WriteLine("Harf Notu : DC -- YE");
                    break;

                case < 69:


                    System.Console.WriteLine("Harf Notu : CC -- YE");
                    break;

                case < 79:


                    System.Console.WriteLine("Harf Notu : CB -- YE");
                    break;

                case < 84:


                    System.Console.WriteLine("Harf Notu : BB -- YE");
                    break;
                case < 89:



                    System.Console.WriteLine("Harf Notu : BA -- YE");
                    break;
                case <= 100:


                    System.Console.WriteLine("Harf Notu : AA -- YE");
                    break;









                default:
                    System.Console.WriteLine("Lütfen 0-100 Arasında Bir Not Giriniz!! ");
                    break;


            }
        }
        else
        {
            System.Console.WriteLine("Lütfen Sayı Giriniz!!!");

        }








    }
}
