using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Player
    {
        private string Name;

        public void PickBall(Board game)
        {
            Console.WriteLine("Player {0} turn", Name);
            Console.Write("Which group do you want to pick: ");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine("How many balls do you want to pick: ");
            int b = int.Parse(Console.ReadLine());
            game.PickBall(g, b);

        }
        public Player(string name)
        {
            this.Name = name;

        }
    }
}
