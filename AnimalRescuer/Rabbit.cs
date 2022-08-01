using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer
{
    internal class Rabbit : Animal
    {
        private bool isAggressive;

        public Rabbit(string name, int age, int health, int hunger, int happiness, string nameFood, string preferateRecreationalActivity, bool isAggressive) : base(name, age, health, hunger, happiness, nameFood, preferateRecreationalActivity)
        {
            this.isAggressive = isAggressive;
        }
        public void jump()
        {
            Console.WriteLine("The rabbit jump");
        }
        public override void sleep()
        {
            Console.WriteLine("The rabbit sleeps with eyes open");
        }
        public override void speak()
        {
            Console.WriteLine("The rabbit speak");
        }
        public string toString()
        {
            return base.toString() + ", isAggressive: " + this.isAggressive;
        }
    }
}
