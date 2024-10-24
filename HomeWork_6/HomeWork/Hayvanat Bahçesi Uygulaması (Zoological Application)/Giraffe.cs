using System;

namespace HomeWork.Hayvanat_Bahçesi_Uygulaması__Zoological_Application_;

public class Giraffe : Animal

{
    public Giraffe(string name, int age, string species) : base(name, age, species)
    {
    }
    public override void MakeSound()
    {
        System.Console.WriteLine($"{Name} bi ses  çıkardı ama ben anlamadım, Onun yaşı {Age} ve kendisi bir {Species} familyasından.");
    }
}
