using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer
{
    internal abstract class Person
    {
        private string name;
        private int age;
        private string hairColor;
        private string height;

        protected Person(string name, int age, string hairColor, string height)
        {
            this.name = name;
            this.age = age;
            this.hairColor = hairColor;
            this.height = height;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string HairColor { get => hairColor; set => hairColor = value; }
        public string Height { get => height; set => height = value; }
    }
}
