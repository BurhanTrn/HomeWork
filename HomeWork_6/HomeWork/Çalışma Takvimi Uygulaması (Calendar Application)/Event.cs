using System;

namespace HomeWork.Çalışma_Takvimi_Uygulaması__Calendar_Application_;

public class Event
{
    public Event(string name, string date, string location)
    {
        Name = name;
        Date = date;
        Location = location;
    }

    public string Name { get; set; }
    public string Date { get; set;    }
    public string Location { get; set; }


    public virtual void aySonuToplantısı()
    {
System.Console.WriteLine("Ay sonu toplantısı yapıldı!");
    }

    public virtual void MarkAsComlete()
    {
        System.Console.WriteLine("Görev tamamlandı");
    }

    public virtual void Pasta()
    {
        System.Console.WriteLine("Pasta Alındı");
    }



    

    public virtual void BilgiVer()
    {
    System.Console.WriteLine($"Etkinlik adı: {Name}\nEtkinlik Tarihi:{Date}\nEtkinlik Yeri:{Location}");
    }
}
