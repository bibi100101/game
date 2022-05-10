using System;

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
        Player playerA;
        Player playerB;
        
        static Random rand = new Random();
        private int randomNumber = rand.Next(0, 100);

        public Game(string nameA, string nameB)
        {
            playerA.name = nameA;
            playerB.name = nameB;
        }
    }

    public struct Player
    {
        public string name;
        public int guess;
    }
}
