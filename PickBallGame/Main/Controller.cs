using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Controller
    {
        Board Game = new Board(3, 4, 6);
        Player A = new Player("A");
        Player B = new Player("B");


        public void PlayGame()
        {
            Game.PrintGame();
            while (true)
            {
                A.PickBall(Game);
                Game.PrintGame();
                if (Game.IsGameOver())
                {
                    Console.WriteLine("Player {0} lose", A.GetName());
                    break;
                }
                B.PickBall(Game);
                Game.PrintGame();
                if (Game.IsGameOver())
                {
                    Console.WriteLine("Player {0} lose", B.GetName());
                    break;
                }
            }
        }
    }
}
