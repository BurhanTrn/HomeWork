using System;

namespace HomeWork.Hayvanat_Bahçesi_Uygulaması__Zoological_Application_;

public class Elephant : Animal

{
    public Elephant(string name, int age, string species) : base(name, age, species)
    {
    }

    public override void MakeSound()
    {
        System.Console.WriteLine($"{Name} boru sesi çıkardı");
    }
}
