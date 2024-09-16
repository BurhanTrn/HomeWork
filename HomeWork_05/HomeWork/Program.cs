using HomeWork.Hayvanat_Bahçesi_Uygulaması__Zoological_Application_;
using HomeWork.Taşıt_Yönetim_Sistemi__Vehicle_Management_System_;

namespace HomeWork;

class Program
{
    static void Main(string[] args)
    {
        // Lion lion1 = new Lion("Burak", 7, "Kedi");
        // Elephant elephant1 = new Elephant("Uğur", 8, "uzunburun");
        // Giraffe giraffe1 = new Giraffe("Samet", 9, "yerdenbacak");

        // lion1.MakeSound();
        // elephant1.MakeSound();
        // giraffe1.MakeSound();

        Car car1 = new Car("Mercedes", "c180", 2016, 5);
        Bicycle bicycle1 = new Bicycle("Kron", "tx150", 2020, "Zili var");
        Motorcycle motorcycle1 = new Motorcycle("Honda", "space", 2023, "Yan sepeti yok");

        motorcycle1.BilgileriEkranaYaz();




    }
}
