using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer
{
    internal class Animal
    {
        private string name;
        private int age;
        private int health;
        private int hunger;
        private string nameFood;
        private string preferateRecreationalActivity;

        public Animal(string name, int age, int health, int hunger, string nameFood, string preferateRecreationalActivity)
        {
            this.name = name;
            this.age = age;
            this.health = health;
            this.hunger = hunger;
            this.nameFood = nameFood;
            this.preferateRecreationalActivity = preferateRecreationalActivity;
        }
    }
}
