using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Board
    {
        int G1, G2, G3;
        public void PickBall(int g, int b)
        {
            if (g == 1)
            {
                if(G1 == 0)
                {
                    Console.WriteLine("There is no more ball in this group for you to pick");
                    Console.WriteLine("you will lose your turn");
                    
                }
                else
                    G1 -= b;
            }
            else if (g == 2)
            {
                if (G2 == 0)
                {
                    Console.WriteLine("There is no more ball in this group for you to pick");
                    Console.WriteLine("you will lose your turn");

                }
                else
                    G2 -= b;
            }
            else

            {
                if (G3 == 0)
                {
                    Console.WriteLine("There is no more ball in this group for you to pick");
                    Console.WriteLine("you will lose your turn");

                }
                else
                    G3 -= b; }
        }
        public void PrintGame()
        {
            Console.Write("Group 1: ");
            for (int i = 0; i < G1; i++)
            {
                Console.Write("O ");
            }
            Console.WriteLine();

            Console.Write("Group 2: ");
            for (int i = 0; i < G2; i++)
            {
                Console.Write("O ");
            }
            Console.WriteLine();

            Console.Write("Group 3: ");
            for (int i = 0; i < G3; i++)
            {
                Console.Write("O ");
            }
            Console.WriteLine();
        }
        public bool IsGameOver()
        {
            return (G1 == 0 && G2 == 0 && G3 == 0);
        }
        public Board(int g1, int g2, int g3)
        {
            this.G1 = g1;
            this.G2 = g2;
            this.G3 = g3;
        }
    }
}
