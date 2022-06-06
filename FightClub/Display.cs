using System;

namespace FightClub
{
    public class Display
    {
        public Display()
        {
            var liste = new wallah(); // 3. liste tilegner seg Characters variablen?

            liste.AddCharacter("Buzz", 2000, "10 Fists", 250, 200,0); //4. liste variablen kaller på addCharacter metoden.
            liste.AddCharacter("Franko", 1250, "Says ugly stuff", 150, 400,1);// 7. Character verdiene ligger også nå i liste variablen
            liste.AddCharacter("Stuart", 1300, "Choke", 230, 300,2);
            liste.AddCharacter("Coby", 900, "Kick in the nut", 440, 440, 3);
            liste.AddCharacter("Manson", 1800, "Backbreaker", 350, 200, 4);

            Console.WriteLine("Choose your fighter: "); // 8. Man kaller nå på første consol?
            liste.PrintAll(); // 9. Man kaller  på printAll metoden?
            liste.ChooseCharacter(); // 14. Choosecharacter metoden blir kalt opp sammen med liste verdiene?
            liste.ChoosenOpponent();
            //var Opponent = liste.ChoosenOpponent();
        }
    }
}