using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFun
{
    public class Animal
    {
        public string name = "Anonymous";
        public int limbCount = 4;
        public string colour = "Brown";
        public int health = 100;

        public string Eat(string food)
        {
            return $"I'm a {colour} animal called {name} using some of my {limbCount} limbs to eat {food}";
        }

        public string Move(int distance, string direction="up")
        {
            return $"I'm a {colour} animal called {name} using some of my {limbCount} limbs to move {direction} for {distance} metres";
        }
    }
}
