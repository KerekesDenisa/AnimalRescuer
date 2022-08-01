using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer
{
    internal class Adoption
    {
        private string name;
        private float amountMoney;

        public Adoption(string name, float amountMoney)
        {
            this.name = name;
            this.amountMoney = amountMoney;
        }
        public string Name { get => name; set => name = value; }
        public float AmountMoney { get => amountMoney; set => amountMoney = value; }


    }
}
