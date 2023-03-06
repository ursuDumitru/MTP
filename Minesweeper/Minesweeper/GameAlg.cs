using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Game
    {

        int GameSize; //size of the game : N x N
        int TotalBombs; // number of bombs int the game
        public List<List<int>> GameArray = new List<List<int>>(); //the array which needs to be populated

        public Game(int gameSize, int bombsNr,int firstX, int firstY)
        {
            GameSize = gameSize;
            TotalBombs = bombsNr;

            for (int i = 0; i < gameSize; i++) //generating the respective game array
            {
                GameArray.Add(new List<int>());
                for (int j = 0; j < gameSize; j++)
                    GameArray[i].Add(0);
            }

            PopulateGameArray(firstX, firstY);
        }

        void PopulateGameArray(int fX, int fY)
        {
            int n = 0;

            while (n < TotalBombs)
            {
                Random rand = new Random();
                int i = rand.Next(0, GameSize);
                int j = rand.Next(0, GameSize);

                if (GameArray[i][j] == 9 && !(i == fX && j == fY)) //daca deja e bomba sau e primul apasat
                    continue;

                GameArray[i][j] = 9; //9 will mean bomb bcouse there can be a maximum of 8 bombs around a square
                n++;
            }
            int[] X = new int[] { -1, 0, 1 }; //directions
            int[] Y = new int[] { -1, 0, 1 };

            for (int i = 0; i < GameSize; i++)
                for (int j = 0; j < GameSize; j++) //iterate thorugh each element
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
}
