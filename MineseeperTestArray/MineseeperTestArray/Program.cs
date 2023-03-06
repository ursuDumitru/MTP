using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MineseeperTestArray
{
    public class Game
    {

        int GameSize; //size of the game : N x N -> will be variable
        int TotalBombs; // number of bombs int the game -> will be variable
        public List<List<int>> GameArray = new List<List<int>>(); //the array which needs to be populated


        public Game(int gameSize, int totalBombs)
        {
            GameSize = gameSize;
            TotalBombs = totalBombs;

            for(int i = 0; i < gameSize; i++) //generating the respective game array
            {
                GameArray.Add(new List<int>());
                for (int j = 0; j < gameSize; j++)
                    GameArray[i].Add(0);
            }

            PopulateGameArray();
        }

        void PopulateGameArray()
        {
            int n = 0;
            
            while (n < GameSize) 
            {
                Random rand = new Random();
                int i = rand.Next(0, GameSize);
                int j = rand.Next(0, GameSize);

                if (GameArray[i][j] == 9)
                    continue;

                GameArray[i][j] = 9; //9 will mean bomb bcouse there can be a maximum of 8 bombs around a square
                
                n++;
            }
            int[] X = new int[] { -1, 0, 1 }; //directions
            int[] Y = new int[] { -1, 0, 1 };

            for (int i = 0; i < GameSize; i++)
                for(int j = 0; j < GameSize; j++) //iterate thorugh each element
                    if (GameArray[i][j] == 9) //if the element is bomb
                        for (int x = 0; x < 3; x++) //interate through each row surrounding it
                            for (int y = 0; y < 3; y++) //iterate through each column surrounding it
                                if (((X[x] + i < GameSize) && (X[x] + i >= 0)) &&
                                    ((Y[y] + j < GameSize) && (Y[y] + j >= 0)) &&
                                    GameArray[i + X[x]][j + Y[y]] != 9 &&
                                    !(X[x] == 0 && Y[y] == 0)) //check things
                                    GameArray[i + X[x]][j + Y[y]] += 1; //increase the nrOfBombs surrounding the given pos.

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(10, 9);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 10; j++)
                    Console.Write(game.GameArray[i][j] + " ");
            }

            Console.ReadKey();
        }
    }
}
