using System;

namespace HomeWork.Taşıt_Yönetim_Sistemi__Vehicle_Management_System_;

public class Motorcycle : Vehicle
{
    public Motorcycle(string make, string model, int year, string hasSidecar) : base(make, model, year)
    {
        HasSidecar = hasSidecar;
    }
    public string HasSidecar { get; set; }

    public override void BilgileriEkranaYaz()
    {
        base.BilgileriEkranaYaz();
        
    }
}
