using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer
{
    internal class RecreationalActivity
    {
        private string name;

        public RecreationalActivity(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
    }
}
