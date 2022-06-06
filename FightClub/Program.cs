using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace FightClub
{
    public class Program//*
    {

        static void Main(string[] args)
        { 
            bool status = true;
            while (status)
            {
                var display = new Display();
                Console.WriteLine(display); // 23. Skriver ut alt fram til nå?
                
                //var Prog = new wallah();
                //status = Prog.Continue();
                //if (status == false) break;

                //Prog.ChoosenOpponent();
                //Console.WriteLine($"Your chosen opponent is: {name}"); // Funker ikke
                Console.ReadKey();

            }


            //List<characters> Characters = new List<characters>();
            //Characters.Add(new characters("Buzz", 2000, "10 Fists", 250, 200));
            //Characters.Add(new characters("Franko", 1250, "Says ugly stuff", 150, 400));
            //Characters.Add(new characters("Stuart", 1300, "Choke", 230, 300));
            //Characters.Add(new characters("Coby", 900, "Kick in the nut", 440, 440));
            //Characters.Add(new characters("Manson", 1800, "Backbreaker", 350, 200));

            //Console.WriteLine("Choose your fighter: ");
            //var i = 0;
            //foreach (characters names in characters.Characters)
            //{
            //    Console.WriteLine("**********************************");
            //    Console.WriteLine($"No: {i}\r\n Name: {names._name}\r\n Health: {names._health}\r\n Superattack name: {names._superattackName}\r\n Superattack Dmg: {names._superattackDamage} \r\n Healing ability: {names._healingAbility}");
            //    i++;
            //}
            //wallah.PrintAll();

            // Console.WriteLine("Write correct number to choose your fighter: ");
            //var playerChampion = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"Do you want to play as: {Characters[playerChampion]._name}?");
            // Console.ReadLine();
        }
        
    }// Prøv å skriv inn lista i characters klassen.
}