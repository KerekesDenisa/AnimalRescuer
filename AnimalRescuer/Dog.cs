using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer
{
    internal class Dog : Animal
    {

        public string Breed { get; set; }
        public bool Scared { get; set; }



        public override void Eat(AnimalFood animalFood)
        {
            Console.WriteLine("The dog eats" + animalFood);
        }

    }
}
