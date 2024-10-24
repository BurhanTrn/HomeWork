using System;

namespace HomeWork.Çalışan_Yönetim_Sistemi__Employee_Management_System_;

public class Menager : Employee
{
    public Menager(string name, int ıd, decimal salary, int numberOfTeams) : base(name, ıd, salary)
    {
        NumberOfTeams = numberOfTeams;
    }
    public int NumberOfTeams { get; set; }
    public override void BilgileriEkranaYazdır()
    {
        System.Console.WriteLine($"Çalışanın Adı: {Name} Kimlik Numarası: {Id} Takım Sayısı: {NumberOfTeams} Çalışanın Maaşı: {Salary}");
    }
}
