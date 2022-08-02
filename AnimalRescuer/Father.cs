using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer
{
    internal class Father : Person
    {
        public Father(string name, int age, string hairColor, string height) : base(name, age, hairColor, height)
        {
            this.Height = "tall";
        }
    }
}

