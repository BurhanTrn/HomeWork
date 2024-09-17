using System;

namespace HomeWork.Çalışan_Yönetim_Sistemi__Employee_Management_System_;

public class Developer : Employee
{
    public Developer(string name, int ıd, decimal salary, string programmingLanguage) : base(name, ıd, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }
    public string ProgrammingLanguage { get; set; }
    public override void BilgileriEkranaYazdır()
    {
        System.Console.WriteLine($"Çalışanın Adı: {Name} Kimlik Numarası: {Id} Bildiği Program Dili: {ProgrammingLanguage} Çalışanın Maaşı: {Salary}");
    }
}
