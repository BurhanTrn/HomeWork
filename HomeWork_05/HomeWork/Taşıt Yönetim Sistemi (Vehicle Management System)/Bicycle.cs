using System;

namespace HomeWork.Taşıt_Yönetim_Sistemi__Vehicle_Management_System_;

public class Bicycle : Vehicle
{
    public Bicycle(string make, string model, int year, string zilVarMi) : base(make, model, year)
    {
        ZilVarMi = zilVarMi;
    }
    public string ZilVarMi { get; set; }    
}
