using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer
{
    internal class Girl : Person,IAdopter
    {
        private bool petLover = true;
        private Animal adoptedPet;

        public Girl(string name, int age, string hairColor, string height, bool petLover, Animal adopedPet) : base(name, age, hairColor, height)
        {
        }

        public bool PetLover { get; set; }
        public Animal AdoptedPet { get; set; }


        public void Adopt(Animal animal)
    {
        Console.WriteLine("The animal " + animal.Name + " was adopted");
        AdoptedPet = animal;
    }

    public void nameAnimal(string name)
    {
        adoptedPet.Name = name;
    }

    public void feedAnimal(AnimalFood food)
    {
        adoptedPet.Eat(food);
    }
}
}
