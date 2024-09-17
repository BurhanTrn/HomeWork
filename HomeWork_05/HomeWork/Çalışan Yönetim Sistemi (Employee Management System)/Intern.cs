using System;

namespace HomeWork.Çalışan_Yönetim_Sistemi__Employee_Management_System_;

public class Intern : Employee
{
    public Intern(string name, int ıd, decimal salary) : base(name, ıd, salary)
    {
    }


    public override void BilgileriEkranaYazdır()
    {
        System.Console.WriteLine($"Çalışanın Adı: {Name} Kimlik Numarası: {Id} Çalışanın Maaşı: {Salary}");
    }
}
