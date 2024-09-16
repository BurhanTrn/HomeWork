using System;

namespace HomeWork.Hayvanat_Bahçesi_Uygulaması__Zoological_Application_;

public class Lion : Animal

{
    public Lion(string name, int age, string species) : base(name, age, species)
    {
    }

    public override void MakeSound()
    {
        System.Console.WriteLine($"{Name} Kükrüyor.. Onun yaşı {Age} ve kendisi bir {Species} familyasından.");
    }

}
