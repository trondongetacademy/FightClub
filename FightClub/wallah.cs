using System;
using System.Collections.Generic;

namespace FightClub
{
    public class wallah
    {
        

        public List<characters> Characters { get; set; } //1. Lager Listen her?

        public int Random()
        {
           Random Rand = new Random();
           return Rand.Next(0, 5);
           
        }

        public wallah() // 2. Lager en metode og når metoden blir kalt opp kaller man opp Characters?
        {
            Characters = new List<characters>();
        }


        public void AddCharacter(string name, int health, string superattakName, int superattackDamage, int healingAbility, int id) //. 5 Addcharacter metoden kalles?
        {
            Characters.Add(new characters(name, health, superattakName, superattackDamage, healingAbility, id)); // 6. Character får de 5 forskjellige verdiene?
        }

        public characters Noe(int index)// 19. Noe blir kalt opp med brukerens valg som index?
        {
            var character = Characters[index]; //20. Lager en variabel som character og tilegner verdien fra Characters (Lista) og kaller opp index nr som brukeren tastet inn?
            return character; // 21. Returnerer valget. Som er index nr i lista?
        }

       public void ChooseCharacter() // 15. ChooseCharacter blir kalt opp med verdiene?
        {
            Console.WriteLine("Write correct number to choose your fighter: "); // 16. console spm blir kalt opp?
            var playerChampion = Convert.ToInt32(Console.ReadLine()); // 17. playerChampion får verdi fra bruker?
            var character = Noe(playerChampion); // 18. lager en variabel med nacn character og kaller opp Noe() metoden med brukerens valg?
            Console.WriteLine($"Do you want to play as: {character.Name}? \'J\' for Yes, \'N\' for No"); // 22. Skriver ut karakteren man ville velge?
            
        }

        public void PrintAll() //10. Metoden blir kalt på
        {
            foreach(var character in Characters) //11. characters variablen lages og går igjennom alle veridene i Characterse lista som får verdiene fra 6?
            {

                character.Print();  //12. Man kaller på print metoden med de forksjellige verdiene hver for seg via character variablen som blir laget i 11?
            }
        }

        //public bool Continue()
        //{
            
        //    var playerChoice = Console.ReadLine();
        //    if (playerChoice == "N")
        //    {
        //        Console.WriteLine("You have chosen to exit..");
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        public void ChoosenOpponent()
        {
            //foreach (var character in Characters)
            //{
            //    var name = character.Name;
            //    Console.WriteLine("Wallah: " + name);
            //}
            var opponentIndex = Random();
            var opponentIs = Characters[2].Name; //Characters[opponentIndex];

            Console.WriteLine($"Your Opponent is: {opponentIs}");
        }
    }
}