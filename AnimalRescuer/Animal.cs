using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer
{
    internal abstract class Animal
    {
        private string name;
        private int age;
        private int health;
        private int hunger;
        private int happiness;
        private string nameFood;
        private string preferateRecreationalActivity;

        public Animal(string name, int age, int health, int hunger, int happiness, string nameFood, string preferateRecreationalActivity)
        {
            this.name = name;
            this.age = age;
            this.health = health;
            this.hunger = hunger;
            this.happiness = happiness;
            this.nameFood = nameFood;
            this.preferateRecreationalActivity = preferateRecreationalActivity;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Health { get => health; set => health = value; }
        public int Hunger { get => hunger; set => hunger = value; }
        public int Happiness { get => happiness; set => happiness = value; }
        public string NameFood { get => nameFood; set => nameFood = value; }
        public string PreferateRecreationalActivity { get => preferateRecreationalActivity; set => preferateRecreationalActivity = value; }

        public abstract void sleep();
        public abstract void speak();

        public string toString()
        {
            return "Name: " + this.Name + 
                    ", Age: " + this.Age + 
                    ", Health: " + this.Health + 
                    ", Hunger: " + this.Hunger + 
                    ", Happiness: " + this.Happiness + 
                    ", Favorite food: " + this.NameFood + 
                    ", Favorite Activity: " + this.PreferateRecreationalActivity;
        }
    }
}
