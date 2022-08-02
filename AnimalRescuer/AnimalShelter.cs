using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer
{
    internal class AnimalShelter
    {
        private List<Animal> availableAnimals;
        public void addAnimal(Animal animal)
        {
            availableAnimals.Add(animal);
        }

        public void removeAnimal(Animal animal)
        {
            availableAnimals.Remove(animal);
        }
    }
}
