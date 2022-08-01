using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer
{
    internal class AnimalFood
    {
        private string name;
        private float price;
        private float quantity;
        private DateOnly expirationDate;
        private bool stock;

        public AnimalFood(string name, float price, float quantity, DateOnly expirationDate, bool stock)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.expirationDate = expirationDate;
            this.stock = stock;
        }

        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public float Quantity { get => quantity; set => quantity = value; }
        public DateOnly ExpirationDate { get => expirationDate; set => expirationDate = value; }
        public bool Stock { get => stock; set => stock = value; }
    }
}
