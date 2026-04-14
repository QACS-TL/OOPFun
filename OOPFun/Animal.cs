using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFun
{
    public class Animal
    {
        public string Name { get; set; } = "Anonymous";
        //private int limbCount = 4;
        public string Colour { get; set; } = "Brown";
        public int Health { get; set; } = 100;

        // The Java Solution
        //public int GetLimbCount(){
        //     return limbCount;
        //}

        //public void SetLimbCount(int value)
        //{
        //    if (value < 0)
        //    {
        //        value = 0;
        //    }
        //    else if (value > 100)
        //    {
        //        value = 100;
        //    }
        //    limbCount = value;
        //}

        private int limbCount = 4;

        public int LimbCount
        {
            get { 
                return limbCount; 
            }
            set {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 100)
                {
                    value = 100;
                }
                limbCount = value; 
            }
        }



        public string Eat(string food)
        {
            return $"I'm a {Colour} animal called {Name} using some of my {LimbCount} limbs to eat {food}";
        }

        public string Move(int distance, string direction="up")
        {
            return $"I'm a {Colour} animal called {Name} using some of my {LimbCount} limbs to move {direction} for {distance} metres";
        }
    }
}
