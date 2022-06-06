using System;
using System.Collections.Generic;

namespace FightClub
{
    public class characters
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public string SuperattackName { get; private set; }
        public int SuperattackDamage { get; private set; }
        public int HealingAbility { get; private set; }
        public int Id { get; private set; }

        public characters(string name, int health, string superattackName, int superattackDamage, int healingAbility, int id)
        {
            Name = name;
            Health = health;
            SuperattackName = superattackName;
            SuperattackDamage = superattackDamage;
            HealingAbility = healingAbility; 
            Id = id;
        }

       

        public void Print() //13. Print blir kalt opp og skriver ut sammen med de forskjellige verdiene fra 11?
        {
            Console.WriteLine("**********************************");
            Console.WriteLine($"No: {Id}\r\n Name: {Name}\r\n Health: {Health}\r\n Superattack name: {SuperattackName}\r\n Superattack Dmg: {SuperattackDamage} \r\n Healing ability: {HealingAbility}");
        }
        
    }


}

//List<characters> Characters = new List<characters>();
//Characters.Add(new characters("Buzz", 2000, "10 Fists", 250, 200));
//Characters.Add(new characters("Franko", 1250, "Says ugly stuff", 150, 400));
//Characters.Add(new characters("Stuart", 1300, "Choke", 230, 300));
//Characters.Add(new characters("Coby", 900, "Kick in the nut", 440, 440));
//Characters.Add(new characters("Manson", 1800, "Backbreaker", 350, 200));
