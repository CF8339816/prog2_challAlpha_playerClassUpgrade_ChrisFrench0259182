using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace prog2_challAlpha_playerClassUpgrade_ChrisFrench0259182
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            Player player1 = new Player();
            Player player2 = new Player();
            player1.SetName("Generic Hero 1");
            player2.SetName("Generic Hero 2");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" player stats ");
            player1.PrintStats();
            player2.PrintStats();

            Console.ReadKey(true);

            player1.TakeDamage();
           // Console.ReadKey(true);
            player2.TakeDamage();

            Console.ReadKey(true);
            Console.Clear();

            player1.PrintStats();
            player2.PrintStats();

            Console.ReadKey(true);

            player1.TakeDamage();
            player1.LevelUp();
           // Console.ReadKey(true);
            player2.TakeDamage();

            Console.ReadKey(true);
            Console.Clear();

            player1.PrintStats();
            player2.PrintStats();

            Console.ReadKey(true);

            player1.TakeDamage();
           // Console.ReadKey(true);
            player2.TakeDamage();
            player2.LevelUp();

            Console.ReadKey(true);
            Console.Clear();

            player1.PrintStats();
            player2.PrintStats();

            Console.ReadKey(true);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($" Creating a list of 100 players.");

            List<Player>adventurHall= new List<Player>();
            for(int i = 1; i<=100;i++)
            {
                Player _PC = new Player();

                _PC.SetName($"Adventurer_{i}");

                adventurHall.Add(_PC);  

            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"\nSuccessfully created ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{adventurHall.Count} " );
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"players in the list.");
            Console.ReadKey(true);


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\nYour party is ready... \n");
            //Random party = new Random();
            //int draft = party.Next(1, 101);

            //adventurHall[draft].PrintStats();
            //adventurHall[draft].PrintStats();
            //adventurHall[draft].PrintStats();
            //adventurHall[draft].PrintStats();
            //adventurHall[draft].PrintStats();

            adventurHall[20].PrintStats();
            adventurHall[35].PrintStats();
            adventurHall[89].PrintStats();
            adventurHall[54].PrintStats();
            adventurHall[11].PrintStats();


            Console.WriteLine($"Press any key to exit...  ");
            Console.ReadKey(true);
            Console.ResetColor();
        }
    }

    public class Player
    {
        string _name;
        int _currentHealth;
        int _maxHealth;
        int _level;
        Random Dmg = new Random();

        public Player()
        {
            _name = "default";
            _currentHealth = 100;
            _maxHealth = 100;
            _level = 1;
        }

        public void SetName(string _newName)
        {
            _name = _newName;

        }


        public void PrintStats()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"Name:  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" {_name}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"Health:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" {_currentHealth}/{_maxHealth}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"Level: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{_level}");
        }


        public void TakeDamage()
        {

            //Random Dmg = new Random();
            int amount = Dmg.Next(5, 21);
            _currentHealth -= amount;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"\n {_name} took ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{amount} ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"damage  ");
            if (_currentHealth < 0) _currentHealth = 0;
            //return;
        }

        public void LevelUp()
        {
            _level++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"\n {_name} Has ained a level! WEEEE!!!!! ");
        }



    }















}
