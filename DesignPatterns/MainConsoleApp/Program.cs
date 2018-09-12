using MainConsoleApp.Observer_1;
using System;

namespace MainConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Observer
            ExampleProduct prod = new ExampleProduct();
            Shop shop1 = new Shop("Shop1");
            Shop shop2 = new Shop("Shop2");
            Shop shop3 = new Shop("Shop3");
            Shop shop4 = new Shop("Shop4");
            prod.Attach(shop1);
            prod.Attach(shop2);

            prod.Attach2(shop3);
            prod.Attach2(shop4);
            prod.ChangePrice(23.0f);

            prod.Detach(shop2);
            prod.Detach2(shop4);
            prod.ChangePrice(8.0f);

            Console.ReadKey();
        }
    }
}