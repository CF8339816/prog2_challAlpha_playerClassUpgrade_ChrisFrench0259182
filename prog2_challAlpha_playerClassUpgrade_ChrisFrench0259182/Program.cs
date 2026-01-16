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
            player1.HUD();
            player2.HUD();

            Console.ReadKey(true);

            player1.TakeDamage();

            player2.TakeDamage();

            Console.ReadKey(true);
            Console.Clear();

            player1.HUD();
            player2.HUD();

            Console.ReadKey(true);

            player1.TakeDamage();
            player1.LevelUp();
            player2.TakeDamage();

            Console.ReadKey(true);
            Console.Clear();

            player1.HUD();
            player2.HUD();

            Console.ReadKey(true);

            player1.TakeDamage();
            
            player2.TakeDamage();
            player2.LevelUp();
            Console.ReadKey(true);
            Console.Clear();

            player1.HUD();
            player2.HUD();



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


        public void HUD()
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

            Random Dmg = new Random();
            int amount = Dmg.Next(5, 21);
            _currentHealth -= amount;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"\n {_name} took ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{amount} ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"damage  ");
            if (_currentHealth < 0) _currentHealth = 0;
            
        }

        public void LevelUp()
        {
            _level++;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"\n {_name} Has ained a level! WEEEE!!!!! ");
        }



    }















}
