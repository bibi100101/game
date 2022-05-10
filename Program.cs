using System;

namespace Nowy_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
        }
    }

    class Game
    {
        Player playerA;
        Player playerB;

        private int randomNumber = Random.Range(0, 100);

        Game(string nameA, string nameB)
        {
            playerA.Name = nameA;
            playerB.Name = nameB;
        }
    }

    public struct Player
    {
        string name;
        int guess;
    }
}
