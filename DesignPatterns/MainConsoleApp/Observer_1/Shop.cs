using System;
using System.Collections.Generic;
using System.Text;

namespace MainConsoleApp.Observer_1
{
    public class Shop : IObserver
    {
        string name;
        float price = 0.0f;
        public Shop(string name)
        {
            this.name = name;
        }

        public void Update(float price)
        {
            this.price = price;
            Console.WriteLine($"Cena produktu {this.name} to {this.price}.");
        }
    }
}
