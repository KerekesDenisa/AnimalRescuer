using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer
{
    internal class Play
    {
        Adoption adoptation;
        Animal dog;
        Vetrinarian vetrinarian;

        public Play(Adoption adoptation, Animal dog, Vetrinarian vetrinarian)
        {
            this.adoptation = adoptation;
            this.dog = dog;
            this.vetrinarian = vetrinarian;
        }
    }
}
