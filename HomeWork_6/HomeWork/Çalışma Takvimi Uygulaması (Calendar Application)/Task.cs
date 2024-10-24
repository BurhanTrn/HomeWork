using System;

namespace HomeWork.Çalışma_Takvimi_Uygulaması__Calendar_Application_;

public class Task : Event
{
    public Task(string name, string date, string location) : base(name, date, location)
    {
    }

    public override void MarkAsComlete()
    {
        base.MarkAsComlete();
    }
}



