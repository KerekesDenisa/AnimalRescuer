using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer
{
    internal class Vetrinarian
    {
        private string name;
        private string specialization;

        public Vetrinarian(string name, string specialization)
        {
            this.name = name;
            this.specialization = specialization;
        }

        public string Name { get => name; set => name = value; }
        public string Specialization { get => specialization; set => specialization = value; }


    }
}
