using System;

namespace Fussballmannschaft
{
    public class Feldspieler
    {
        public string Name { get; private set; }

        public Feldspieler(string name)
        {
            Name = name;
        }

        public void AufsTorSchiessen()
        {
            Console.WriteLine($"{Name} schießt aufs Tor!");
        }

        public void Graetschen()
        {
            Console.WriteLine($"{Name} macht eine Blutgrätsche!");
        }

        public void Dribbeln()
        {
            Console.WriteLine($"{Name} dribbelt den Gegner schwindlig!");
        }
    }
}