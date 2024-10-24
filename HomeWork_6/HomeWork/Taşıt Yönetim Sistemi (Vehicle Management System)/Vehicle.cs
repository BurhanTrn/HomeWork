using System;

namespace HomeWork.Taşıt_Yönetim_Sistemi__Vehicle_Management_System_;
// 2. Taşıt Yönetim Sistemi(Vehicle Management System)


// Bir `Vehicle` (Taşıt) sınıfı oluşturun.Bu sınıf aşağıdaki özelliklere sahip olmalıdır:
// - `Make` (marka): Taşıtın markası
// - `Model` (model): Taşıtın modeli
// - `Year` (yıl): Taşıtın üretim yılı

// Bu temel sınıftan `Car` (Araba), `Bicycle` (Bisiklet) ve `Motorcycle` (Motosiklet) sınıflarını türetin.Her taşıt türüne özel bir özellik ekleyin(örneğin, `Car` için `NumberOfDoors` (Kapı Sayısı), `Motorcycle` için `HasSidecar` (Yan Sepet Var mı)).


public class Vehicle
{
    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
  

    public virtual void BilgileriEkranaYaz()
    {
        System.Console.Write($"Marka: {Make} Model: {Model} Yıl: {Year}\n");
    }

    


}
