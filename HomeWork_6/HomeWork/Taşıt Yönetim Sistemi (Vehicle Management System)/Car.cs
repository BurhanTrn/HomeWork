using System;

namespace HomeWork.Taşıt_Yönetim_Sistemi__Vehicle_Management_System_;

public class Car : Vehicle
{
    public Car(string make, string model, int year, int numberOfDoors) : base(make, model, year)
    {
        NumberOfDoors = numberOfDoors;
    }
    public int NumberOfDoors { get; set; }

    public override void BilgileriEkranaYaz()
    {
        base.BilgileriEkranaYaz();
    }
}
