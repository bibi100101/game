using System;
using System.Collections.Generic;
using System.Linq;

namespace Nowy_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwe: ");
            string name1 = Console.ReadLine();

            Console.WriteLine("Podaj nazwe: ");
            string name2 = Console.ReadLine();

            Game game = new Game(name1, name2);
        }
    }

    public class Game
    {
        //tworzy graczy i liste odpowiedzi
        Player playerA;
        Player playerB;

        List<int> guesses = new List<int>();
        
        
        
        public Game(string nameA, string nameB)
        {
            //daje imię graczom
            playerA.name = nameA;
            playerB.name = nameB;

            //gra w nieskończoność
            while (true)
            {
               Play(); 
            }
        }

        //*Głowna gra
        public void Play()
        {
            //*tworzy odpowiedź
            Random rand = new Random();
            int randomNumber = rand.Next(0, 100);
            
            //Bierze odpowiedzi graczy i dodaje je do listy
            Console.WriteLine($"{playerA.name}, podaj liczbe");
            playerA.guess = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{playerB.name}, podaj liczbe");
            playerB.guess = Convert.ToInt32(Console.ReadLine());

            guesses.Add(playerA.guess);
            guesses.Add(playerB.guess);
            
            //!sprawdza jaka odpowiedź jest najbliższa do prawidłowej odpowiedzi
            int closest = guesses.Aggregate((x, y) => Math.Abs(x - randomNumber) < Math.Abs(y - randomNumber) ? x : y);
            
            //pisze prawodłową odpowiedź
            Console.WriteLine($"Prawidlowa odpowiedz to: {randomNumber}");
            
            //pisze kto wygrał
            if (playerA.guess == closest)
            {
                Console.WriteLine($"{playerA.name} Wygral!");
            }
            else if (playerB.guess == closest)
            {
                Console.WriteLine($"{playerB.name} Wygral");
            }
        }
    }

    //!struktura gracza
    public struct Player
    {
        public string name;
        public int guess;
    }
}
