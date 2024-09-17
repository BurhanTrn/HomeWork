using System;

namespace HomeWork.Çalışan_Yönetim_Sistemi__Employee_Management_System_;

public class Employee
{
    public Employee(string name, int ıd, decimal salary)
    {
        Name = name;
        Id = ıd;
        Salary = salary;
    }

    public string Name { get; set; }
    public int Id { get; set; }
    public decimal Salary { get; set; }

    public virtual void BilgileriEkranaYazdır()
    {
        System.Console.WriteLine($"Çalışanın Adı: {Name} Kimlik Numarası: {Id} Çalışanın Maaşı: {Salary}");
    }

}
