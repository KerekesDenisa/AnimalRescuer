using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer
{
    internal abstract class Animal
    {
        public int Age { get; set; }
        public int Weight { get; set; }
        public bool isHungry { get; set; }
        public HappinessStates HappinesLevel { get; set; }
        public string Name{ get; set; }

        public abstract void Eat(AnimalFood animalFood);

    }
}
